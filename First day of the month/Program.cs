using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_day_of_the_month
{
	internal class Program
	{
		// 取得本月一日
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int year = today.Year;
			int month = today.Month;
			DateTime FirstDay = new DateTime(year, month, 1);
			Console.WriteLine(FirstDay);
		}
	}
}
