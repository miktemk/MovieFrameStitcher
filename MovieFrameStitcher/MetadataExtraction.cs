using MovieFrameStitcher.VideoMetaXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MovieFrameStitcher
{
	public class MetadataExtraction : OpBaseClass
	{
		const int SampleRate = 8000;
		const int ImgWidth = 500;
		const int ImgHeight = 50;

		//TODO: it is stupid that meta extraction is in the constructor
		public MetadataExtraction(string filename, string outFilename)
			: base()
		{
			//MakeSureTmpFolderExists();
			RunFfMpegMeta(filename, outFilename);
		}

		private void RunFfMpegMeta(string filename, string outFilename)
		{
            var countFramesMaybe = ""; // "-count_frames";
			Process process = new Process();
			ProcessStartInfo si = new ProcessStartInfo();
			// Configure the process using the StartInfo properties.
			si.FileName = FfprobeExecutable;
			si.Arguments = String.Format("-v quiet -print_format xml -show_format -show_streams {1} \"{0}\"", filename, countFramesMaybe);
			si.UseShellExecute = false;
			si.RedirectStandardOutput = true;
			si.CreateNoWindow = true;
			si.WindowStyle = ProcessWindowStyle.Hidden;

			try
			{
				using (Process ppp = Process.Start(si))
				{
					using (StreamReader reader = ppp.StandardOutput)
					{
						string resultXmlString = reader.ReadToEnd();
						File.WriteAllText(outFilename, resultXmlString);
						MetaXml = LoadMetaFromXmlString(resultXmlString);
					}
					ppp.WaitForExit();
				}
				ResultCode = OpResultCode.OK;
			}
			catch (Win32Exception ex) {
				if (ex.NativeErrorCode == 2)
					ResultCode = OpResultCode.FileNotFound;
				else {
					ResultCode = OpResultCode.OtherError;
					ErrorMessage = ex.Message;
				}
			} catch (Exception ex) {
				ResultCode = OpResultCode.OtherError;
				ErrorMessage = ex.Message;
			}
		}


		public static VideoMetadataUseful LoadMetaFromXml(string filenameXml)
		{
			XmlSerializer x = new XmlSerializer(typeof(ffprobe));
			ffprobe meta;
			using (var fs = new FileStream(filenameXml, FileMode.Open))
				meta = (ffprobe)x.Deserialize(fs);
			return new VideoMetadataUseful(meta);
		}

		public static VideoMetadataUseful LoadMetaFromXmlString(string xmlString)
		{
			XmlSerializer x = new XmlSerializer(typeof(ffprobe));
			ffprobe meta;
			using (var tr = new StringReader(xmlString))
				meta = (ffprobe)x.Deserialize(tr);
			return new VideoMetadataUseful(meta);
		}

		public VideoMetadataUseful MetaXml { get; private set; }
	}
}
