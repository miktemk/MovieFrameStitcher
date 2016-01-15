using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MovieFrameStitcher
{
	public static class Utils
	{
		public static void Clear<T>(this T[] arr)
			where T: class
		{
			if (arr == null)
				return;
			for (int i = 0; i < arr.Length; i++)
				arr[i] = null;
		}

		private static Regex regexSomewhereNumber = new Regex(@"(\d+)");
		public static int ThumbFilenameToInteger(this string filename)
		{
			var match = regexSomewhereNumber.Match(filename);
			if (!match.Success)
				return int.MaxValue;
			var numberStr = match.Groups[0].Value;
			int value = int.MaxValue;
			int.TryParse(numberStr, out value);
			return value;
		}
	}
}
