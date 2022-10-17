using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMember_Trim
{
	internal class Program
	{
		/// <summary>
		/// 將"  abc  " 左右的空白刪除
		/// </summary>
		static void Main(string[] args)
		{
			string value = "  abc  ";
			value = value.Trim();

			Console.WriteLine(value);
		}
	}
}
