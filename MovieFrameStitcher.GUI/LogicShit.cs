using MovieFrameStitcher.VideoMetaXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFrameStitcher.GUI
{
    public class LogicShit
    {
        public delegate void MetaXMLParamHandler(VideoMetadataUseful meta);
        public delegate void MetaErrorHandler(OpResultCode code, string errorMessage1, string errorMessage2);
        public event MetaXMLParamHandler MetaReady;
        public event MetaErrorHandler MetaError;

        private TaskQueueInOtherThread taskThread;

        public LogicShit()
        {
            taskThread = new TaskQueueInOtherThread();
        }

        public void LoadMetadataForVideo(string filename)
        {
            var filenameMeta = StitcherIO.GetMetaFilenameForVideo(filename);
            taskThread.QueueThisUpPlease(() =>
            {
                if (!File.Exists(filenameMeta))
                {
                    // generates the thumbnails
                    var op1 = new MetadataExtraction(filename, filenameMeta);
                    if (op1.ResultCode != OpResultCode.OK && MetaError != null)
                        MetaError(op1.ResultCode, op1.ErrorMessage, op1.ErrorMessage2);
                    if (MetaReady != null && op1.MetaXml != null)
                        MetaReady(op1.MetaXml);
                }
                else
                {
                    var metaXml = MetadataExtraction.LoadMetaFromXml(filenameMeta);
                    if (MetaReady != null)
                        MetaReady(metaXml);
                }

            });
        }
    }
}
