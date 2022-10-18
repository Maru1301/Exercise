using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入日期: ");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("請輸入正確日期");
				return;
			}

			bool isDate = DateTime.TryParse(input, out DateTime dt);

			int day = dt.Day;

			if(day <= 10)
			{
				Console.WriteLine("上旬");
			}
			else if(day<= 20)
			{
				Console.WriteLine("中旬");
			}
			else
			{
				Console.WriteLine("下旬");
			}
		}
	}
}
