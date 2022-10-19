using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_IsPrime
{
	/// <summary>
	/// 判斷某整數 (>1) 是不是質數
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int prime1 = 2, prime2 = 3;
			Console.Write("請輸入一個大於一的整數: ");
			bool isInt = int.TryParse(Console.ReadLine(), out int num);

			if (!isInt)
			{
				Console.WriteLine("輸入錯誤");
				return;
			}
			else if (num < 1)
			{
				Console.WriteLine("數字必須大於一");
				return;
			}

			if (num == prime1 || num == prime2)
			{
				Console.WriteLine($"{num}是質數");
				return;
			}
			else if (num % prime1 == 0)
			{
				Console.WriteLine($"{num}不是質數,被{prime1}整除");
				return;
			}

			for (int i = prime2; i <= Math.Sqrt(num); i += 2)
			{
				if (num % i == 0)
				{
					Console.WriteLine($"{num}不是質數,被{i}整除");
					return;
				}
			}
			Console.WriteLine($"{num}是質數");
		}
	}
}