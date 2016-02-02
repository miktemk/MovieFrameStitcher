using MovieFrameStitcher.GUI.Properties;
using MovieFrameStitcher.VideoMetaXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miktemk;
using Miktemk.Winforms;

namespace MovieFrameStitcher.GUI
{
    public partial class FormStitcher : Form
    {
        private LogicShit logic;

        public string CurFilename { get; set; }
        public VideoMetadataUseful CurMeta { get; set; }

        public FormStitcher()
        {
            InitializeComponent();

            pictureWHDepArrow.Visible = false;
            btnExtract.Enabled = false;
            btnDeleteOld.Enabled = false;

            logic = new LogicShit();
            logic.MetaReady += logic_MetaReady;
            logic.MetaError += logic_MetaError;
        }

        private void fileDragPanel_Load(object sender, EventArgs e)
        {
            fileDragPanel.ExtensionsAllowed = Settings.Default.FileExtensionsVideo;
            fileDragPanel.FileDropped += fileDragPanel_FileDropped;
        }

        private void fileDragPanel_FileDropped(string filename)
        {
            CurFilename = filename;
            lblVideoData.Text = "Extracting meta, please wait...";
            pictureWHDepArrow.Visible = false;
            btnExtract.Enabled = false;
            btnDeleteOld.Enabled = false;
            logic.LoadMetadataForVideo(filename);
        }

        private void logic_MetaReady(VideoMetadataUseful meta)
        {
            CurMeta = meta;
            this.InvokeOrNot_IDontGiveAShit_JustDoIt(() =>
            {
                btnExtract.Enabled = true;
                btnDeleteOld.Enabled = true;
                pictureWHDepArrow.Visible = true;
                txtWidth.Text = CurMeta.rawVideoStream.width + "";
                txtHeight.Text = CurMeta.rawVideoStream.height + "";
                txtInterval.Text = "0.5";
                UpdateVideoData();
            });
        }

        private void logic_MetaError(OpResultCode code, string errorMessage1, string errorMessage2)
        {
            if (code == OpResultCode.FileNotFound)
                MessageBox.Show(@"You need to download ffmpeg and add its ""bin"" folder is in your PATH.
I need the following commands:
 - ffprobe
 - ffmpeg");
        }

        private void UpdateVideoData()
        {
            if (CurMeta == null)
                return;
            var durationS = (double)CurMeta.rawVideoStream.duration;
            var interval = txtInterval.Text.ParseDoubleOrDefault(0.5);
            lblVideoData.Text = String.Format(@"Dim: {3} x {4}
Length: {0}
Thumbs (@{1}): {2}",
                TimeSpan.FromSeconds(durationS).ToTsString(),
                interval,
                (int)(durationS / interval),
                CurMeta.rawVideoStream.width,
                CurMeta.rawVideoStream.height);
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (CurFilename == null)
                return;

            var thumbFolder = StitcherIO.GetThumbsDirectoryForVideo(CurFilename);
            var thumbW = txtWidth.Text.ParseIntOrDefault((CurMeta != null) ? CurMeta.rawVideoStream.width : 64);
            var thumbH = txtHeight.Text.ParseIntOrDefault((CurMeta != null) ? CurMeta.rawVideoStream.height : 32);
            var interval = txtInterval.Text.ParseDoubleOrDefault(0.5);

            if (!Directory.Exists(thumbFolder))
                Directory.CreateDirectory(thumbFolder);

            var ffmpegExtraction = new ThumbnailGenerationWithFfmpeg(CurFilename, thumbFolder, thumbW, thumbH, interval);
            ffmpegExtraction.run();

            if (ffmpegExtraction.ResultCode != OpResultCode.OK)
                MessageBox.Show(ffmpegExtraction.ErrorMessage + "\n" + ffmpegExtraction.ErrorMessage2, ffmpegExtraction.ResultCode.ToString());
        }

        private void btnDeleteOld_Click(object sender, EventArgs e)
        {
            var thumbFolder = StitcherIO.GetThumbsDirectoryForVideo(CurFilename);
            if (!Directory.Exists(thumbFolder))
                return;
            if (Directory.GetFiles(thumbFolder).Length == 0)
                return;
            var result = MessageBox.Show("All previously generated thumbs for this video will be deleted... Proceed?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
                return;
            Directory.Delete(thumbFolder, true);
            Directory.CreateDirectory(thumbFolder);
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (CurMeta != null)
            {
                var thumbW = txtWidth.Text.ParseIntOrDefault(CurMeta.rawVideoStream.width);
                int calcHeight = thumbW * CurMeta.rawVideoStream.height / CurMeta.rawVideoStream.width;
                txtHeight.Text = calcHeight + "";
            }
        }

        private void txtInterval_TextChanged(object sender, EventArgs e)
        {
            UpdateVideoData();
        }
    }
}
