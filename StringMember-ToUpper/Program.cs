using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMember_ToUpper
{
	internal class Program
	{
		/// <summary>
		/// 將字串 "Allen Kuo" 轉成大寫 "ALLEN KUO"
		/// </summary>
		static void Main(string[] args)
		{
			string value = "Allen Kuo";
			value.ToUpper();
			Console.WriteLine(value);
		}
	}
}
