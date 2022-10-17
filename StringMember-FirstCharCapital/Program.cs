using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMember_FirstCharCapital
{
	internal class Program
	{
		/// <summary>
		/// 將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
		/// </summary>
		static void Main(string[] args)
		{
			string value = "aLLeN kUO";
			value = value.ToLower();

			//solution1
			//TextInfo text = new System.Globalization.CultureInfo("en-US", false).TextInfo;
			//value = text.ToTitleCase(value);

			//solution2
			string firstChar = value.Substring(0, 1).ToUpper();
			string rest1 = value.Substring(1, 4);
			string nextFirstChar = value.Substring(6, 1).ToUpper();
			string rest2 = value.Substring(7, 2);

			string result = firstChar + rest1 +" " +  nextFirstChar + rest2;

			Console.WriteLine(result);
		}
	}
}
