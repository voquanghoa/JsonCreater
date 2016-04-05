using System;
using System.IO;
using System.Linq;

namespace JsonCreater
{
	public class TextConverter
	{
		private bool isValidCharacter(char x){
			x = Char.ToLower (x);
			if (Char.IsNumber (x)) {
				return true;
			}

			if (x <= 'z' && x >= 'a') {
				return true;
			}

			return "._".Contains (x);

		}

		public string FormatFullFileName(string fileName){
			return new string (fileName.Select (x => isValidCharacter (x) ? x : '_').ToArray ());
		}

		public string FormatFileName(string fileName){
			fileName = FormatFullFileName (fileName);
			return Path.GetFileNameWithoutExtension (fileName);
		}

		public string FormatDisplay(string fileName){
			fileName = Path.GetFileNameWithoutExtension (fileName);
			fileName = Char.ToUpper (fileName [0]) + fileName.Substring (1).ToLower ();
			fileName = fileName.Replace ('_', ' ');
			return fileName;
		}
	}
}

