using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFrameStitcher.GUI
{
    public static class Utils
    {
        public static int ParseIntOrDefault(this string s, int def = 0)
        {
            int res = 0;
            if (int.TryParse(s, out res))
                return res;
            return def;
        }
        public static float ParseFloatOrDefault(this string s, float def = 0)
        {
            float res = 0f;
            if (float.TryParse(s, out res))
                return res;
            return def;
        }
        public static double ParseDoubleOrDefault(this string s, double def = 0)
        {
            double res = 0f;
            if (double.TryParse(s, out res))
                return res;
            return def;
        }

        public static string ToTsString(this TimeSpan ts)
        {
            return ts.ToString("h\\:mm\\:ss\\.ff");
        }
        public static string ToTsString2(this TimeSpan ts)
        {
            return ts.ToString("m\\:ss\\.ff");
        }

        public static string GetFullPathNoExtension(string file)
        {
            if (file == null)
                return null;
            return Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file));
        }

        public static void InvokeOrNot_IDontGiveAShit_JustDoIt(this Control control, Action func)
        {
            if (control.InvokeRequired)
            {
                if (control.IsDisposed)
                    return;
                control.Invoke(new MethodInvoker(func));
                return;
            }
            func();
        }
    }
}
