using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameCheck
{
	internal class Program
	{
		/// <summary>
		/// 比對使用者輸入值是否為 "Allen", 區分大小寫
		/// </summary>
		static void Main(string[] args)
		{
			string answer = "Allen";
			Console.Write("請輸入你的名字: ");
			string input = Console.ReadLine();

			if (input == answer)
			{
				Console.WriteLine("輸入正確");
			}
			else
			{
				Console.WriteLine("輸入錯誤");
			}
		}
	}
}
