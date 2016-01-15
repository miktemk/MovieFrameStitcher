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

namespace MovieFrameStitcher
{
	public class ThumbnailStitcher : OpBaseClass
	{
		public delegate void GeneratingFile_H(string filename);
		public event GeneratingFile_H GeneratingFile;

		private string folderThumbs;
		private string outTemplate;
		private int nCol;
		private int nRow;
		private int pagesAccross;
		private int thumbW;
		private int thumbH;

		public ThumbnailStitcher(
			string folderThumbs, string outTemplate,
			int nCol, int nRow, int pagesAccross,
			int thumbW, int thumbH)
			: base()
		{
			this.folderThumbs = folderThumbs;
			this.outTemplate = outTemplate;
			this.nCol = nCol;
			this.nRow = nRow;
			this.pagesAccross = pagesAccross;
			this.thumbW = thumbW;
			this.thumbH = thumbH;
		}

		public void run()
		{
			var sampleFirst = getFilename_page(7); // 7 is just a random number
			MakeSureFolderExistsFor(sampleFirst);

			var imgsFiles = Directory.GetFiles(folderThumbs)
				//.Where(fff => fff.Contains("out") && fff.Contains(".jpg"))  //TODO: fix the thumb template! it should be {0}/out{1}
				.Where(fff => fff.Contains(".jpg"))
				.OrderBy(fff => fff.ThumbFilenameToInteger())
				.ToArray();
			if (imgsFiles.Length == 0) {
				ErrorMessage2 = "No thumbnails found in tmp directory";			
				return;
			}

			var imagesPerPage = nRow * nCol;
			var nPages = (int)Math.Ceiling((double)imgsFiles.Length / imagesPerPage);
			if (nPages % pagesAccross != 0) // nPages should be a multiple of pagesAccross
				nPages += pagesAccross - (nPages % pagesAccross);
			var thumbsAccrossAllPages = nCol * pagesAccross;

			string[] thumbsOnThisPage = new string[imagesPerPage];
			for (int i = 0; i < nPages; i++)
			{
				var outFilename = getFilename_page(i + 1);
				thumbsOnThisPage.Clear();

				var startThumbIndex_pageRow = (imagesPerPage * pagesAccross) * (i / pagesAccross); // page 1-4 = 0, pages 5-8 = 1*imagesPerPage, etc
				var startThumbIndex_offset = (nCol) * (i % pagesAccross); // same for pages 1,5,9 for 2,6,10, etc

				var thumbsOnThisPageIndex = 0;
				for (int r = 0; r < nRow; r++)
				{
					for (int c = 0; c < nCol; c++)
					{
						var thumbIndex = startThumbIndex_pageRow // this page row's first page top left corner thumb index
							+ r * thumbsAccrossAllPages // however many rows of thumbs we are down
							+ c + startThumbIndex_offset; // within that row - curCol and, ofcourse, the offset wrt page in that page row
						thumbsOnThisPage[thumbsOnThisPageIndex] = (thumbIndex < imgsFiles.Length)
							? Path.Combine(folderThumbs, imgsFiles[thumbIndex])
							: null;
						thumbsOnThisPageIndex++;
					}
				}

				if (GeneratingFile != null)
					GeneratingFile(outFilename);
				MakePageImage(outFilename, thumbsOnThisPage);
			}
		}

		private void MakePageImage(string outFilename, string[] thumbsOnThisPage)
		{
			Bitmap allThumbs = new Bitmap(nCol * thumbW, nRow * thumbH);
			Graphics ggg = Graphics.FromImage(allThumbs);
			int i = 0;
			for (int r = 0; r < nRow; r++)
			{
				for (int c = 0; c < nCol; c++)
				{
					if (i >= thumbsOnThisPage.Length)
						break;
					var fileThumb = thumbsOnThisPage[i];
					i++;
					if (fileThumb == null)
						continue;
					Bitmap bmp = (Bitmap)Image.FromFile(fileThumb);
					ggg.DrawImage(bmp, thumbW * c, thumbH * r);
					bmp.Dispose();
				}
				if (i >= thumbsOnThisPage.Length)
					break;
			}
			ggg.Flush();

			// save all to one jpg file
			if (File.Exists(outFilename))
			{
				File.Delete(outFilename);
			}
			allThumbs.Save(outFilename, ImageFormat.Jpeg);
			allThumbs.Dispose();
		}

		private string getFilename_page(int index) {
			return outTemplate.Replace("%d", ""+index);
		}
	}
}
