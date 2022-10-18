using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMembers2_Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入你的手機號碼: ");
			string input = Console.ReadLine();
			if(input.Length != 10)
			{
				Console.WriteLine("錯誤的手機號碼");
				return;
			}

			string start = input.Substring(0, 4);
			string end = input.Substring(8, 2);
			string stars = new string('*', 4);

			string result = start + stars + end;

			Console.WriteLine(result);
		}
	}
}
