using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_day_of_the_month
{
	internal class Program
	{
		// 取得本月最後一天
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int year = today.Year;
			int month = today.Month;
			int days = DateTime.DaysInMonth(year, month);
			DateTime LastDay = new DateTime(year, month, days);
			Console.WriteLine(LastDay);
		}
	}
}
