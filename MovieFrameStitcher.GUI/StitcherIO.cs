using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFrameStitcher.GUI
{
    public static class StitcherIO
    {
        public static string GetThumbsDirectoryForVideo(string filename)
        {
            return Utils.GetFullPathNoExtension(filename) + "-thumbs";
        }

        public static string GetMetaFilenameForVideo(string filename)
        {
            return filename + "-meta.xml";
        }
    }
}
