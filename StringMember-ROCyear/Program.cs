using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMember_ROCyear
{
	/// <summary>
	/// 假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "1100225";
			int year = Convert.ToInt32(value.Substring(0, 3));
			year += 1911;

			string result = year + value.Substring(3, 4);
			Console.WriteLine(result);
		}
	}
}
