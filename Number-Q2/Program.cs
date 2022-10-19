using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_IsPrime2
{
	/// <summary>
	/// 找出數值區間內的所有質數
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] primes = new int[0];
			int index = 0;
			Console.WriteLine("請輸入一個數值區間");
			Console.Write("起始值: ");
			bool isIntStart = int.TryParse(Console.ReadLine(), out int start);
			if (!isIntStart)
			{
				Console.WriteLine("輸入錯誤");
			}
			Console.Write("結束值: ");
			bool isIntEnd = int.TryParse(Console.ReadLine(), out int end);
			if (!isIntEnd)
			{
				Console.WriteLine("輸入錯誤");
				return;
			}

			if (start >= end)
			{
				Console.WriteLine("區間不得為零或負值");
				return;
			}

			if(start  <= 1)
			{
				start = 2;
			}

			if (start == 2)
			{
				Array.Resize(ref primes, index + 1);
				primes[index] = start;
				index++;
				start++;
			}
			else if (start % 2 == 0)
			{
				start++;
			}

			for (int num = start; num <= end; num += 2)
			{
				bool isPrime = true;
				for (int i = 3; i <= Math.Sqrt(num); i += 2)
				{
					if (num % i == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					Array.Resize(ref primes, index + 1);
					primes[index] = num;
					index++;
				}
			}

			Console.Write($"{start}~{end}是質數的有: ");
			foreach (int prime in primes)
			{
				Console.Write(prime + " ");
			}
		}
	}
}
