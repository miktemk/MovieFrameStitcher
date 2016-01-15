using MovieFrameStitcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            var interval = 0.5;
            var videoFile = @"C:\Users\Mikhail\Downloads\under-tuscan-sun-2003.mp4";

            //var thumbFolder = @"C:\Users\Mikhail\Videos\colombianaThumbs";
            //var outTemplate = @"C:\Users\Mikhail\Videos\colombianaPages\page-%d.jpg";
            //var thumbW = 320;
            //var thumbH = 136;
            //var nCol = 10;
            //var nRow = 34;
            //var pagesAccross = 4;

            //var thumbFolder = @"C:\Users\Mikhail\Videos\bladeRunnerThumb";
            //var outTemplate = @"C:\Users\Mikhail\Videos\bladeRunnerPages\page-%d.jpg";
            //var thumbW = 320;
            //var thumbH = 132;
            ////var nCol = 10; //A4
            ////var nRow = 34;
            //var nCol = 20; //A3: 29.7 cm x 42 cm
            //var nRow = 34;
            ////var nCol = 16;
            ////var nRow = 54;
            //var pagesAccross = 2;

            var thumbFolder = @"C:\Users\Mikhail\Downloads\tsun";
            var outTemplate = @"C:\Users\Mikhail\Downloads\tsun-pages\page-%d.jpg";
            var thumbW = 240;
            var thumbH = 130;
            var nCol = 20;
            var nRow = 28;
            var pagesAccross = 2;

            //var ffmpegExtraction = new ThumbnailGenerationWithFfmpeg(videoFile, thumbFolder, thumbW, thumbH, interval);
            //ffmpegExtraction.run();


            var stitching = new ThumbnailStitcher(thumbFolder, outTemplate, nCol, nRow, pagesAccross, thumbW, thumbH);
            stitching.GeneratingFile += (string filename) =>
            {
                Console.WriteLine("generating {0}", filename);
            };
            stitching.run();
        }
    }
}
