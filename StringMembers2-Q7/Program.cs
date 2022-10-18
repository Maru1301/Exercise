using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMembers2_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入兩個含有小數點的數: ");
			bool isDecimal1 = decimal.TryParse(Console.ReadLine(), out decimal num1), 
				isDecimal2 = decimal.TryParse(Console.ReadLine(), out decimal num2);

			decimal sum = num1 + num2;

			string result = sum.ToString("#.##");

			Console.WriteLine(result);
		}
	}
}
