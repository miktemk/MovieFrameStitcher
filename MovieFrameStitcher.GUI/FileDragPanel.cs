using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MovieFrameStitcher.GUI
{
    public partial class FileDragPanel : UserControl
    {
        public delegate void StringParamHandler(string s);

        public event StringParamHandler FileDropped;
        public string ExtensionsAllowed { get; set; }

        public FileDragPanel()
        {
            InitializeComponent();
        }
        private void FileDragPanel_Load(object sender, EventArgs e) { }

        private void FileDragPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string file1 = files.FirstOrDefault();
                if (FilenameExtensionIsCorrect(file1))
                {
                    e.Effect = DragDropEffects.Copy;
                    this.BackColor = Color.Aqua;
                }
            }
        }

        private bool FilenameExtensionIsCorrect(string file1)
        {
            if (String.IsNullOrEmpty(ExtensionsAllowed))
                return true;
            var ext = Path.GetExtension(file1).ToLower();
            return ExtensionsAllowed.Split('|').Any(e => e == ext);
        }

        private void FileDragPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string file1 = files.FirstOrDefault();
            if (FilenameExtensionIsCorrect(file1))
            {
                e.Effect = DragDropEffects.Copy;
                this.BackColor = Color.LightGreen;
                lblFile.Text = Path.GetFileName(file1);
                if (FileDropped != null)
                    FileDropped(file1);
            }
        }

        private void FileDragPanel_DragLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }
    }
}
