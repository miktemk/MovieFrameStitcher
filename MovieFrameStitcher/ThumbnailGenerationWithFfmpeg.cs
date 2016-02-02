//#define ONE_LINE_TEST

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Globalization;

namespace MovieFrameStitcher
{
	public class ThumbnailGenerationWithFfmpeg : OpBaseClass
	{
		private string filename;
		private string outFolder;
		private int thumbW;
		private int thumbH;
		private double interval;

		public ThumbnailGenerationWithFfmpeg(string filename, string outFolder, int thumbW, int thumbH, double interval)
			: base()
		{
			this.filename = filename;
			this.outFolder = outFolder;
			this.thumbW = thumbW;
			this.thumbH = thumbH;
			this.interval = interval;
		}

		public void run()
		{
			MakeSureFolderExists(outFolder);

			Process process = new Process();
			process.StartInfo.FileName = FfmpegExecutable;
            // .... NOTE: "-q:v 1" option is needed to extract images of highest possible quality
            // .... http://superuser.com/questions/318845/improve-quality-of-ffmpeg-created-jpgs
            process.StartInfo.Arguments = String.Format("-i \"{0}\" -y -f image2 -q:v 1 -vf \"scale={2},fps=fps=1/{3}\" \"{1}/out%d.jpg\"",
                filename, outFolder, thumbW + ":" + thumbH, interval.ToString(CultureInfo.InvariantCulture));
			process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            SimpleLog.Log(process.StartInfo.Arguments);

			//process.StartInfo.CreateNoWindow = true;

			runProcessRememberError(process);
		}
	}
}
