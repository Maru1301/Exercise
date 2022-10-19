using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every_Sunday_in_this_year
{
	internal class Program
	{
		// 列出指定年份的每一個星期日
		static void Main(string[] args)
		{
			Console.Write("請輸入年份: ");
			bool isInt = int.TryParse(Console.ReadLine(), out int year);
			if (!isInt)
			{
				Console.WriteLine("輸入錯誤");
			}
			List<DateTime> Sundays = new List<DateTime>();

			//find the first Sunday
			DateTime firstSunday = new DateTime(year, 1, 1);

			int dayofweek = Convert.ToInt32(firstSunday.DayOfWeek);
			int difference = 0;
			while (dayofweek != 0)
			{
				difference++;
				dayofweek++;
				if (dayofweek == 7)
				{
					break;
				}
			}
			firstSunday = firstSunday.AddDays(difference);

			for (DateTime Sunday = firstSunday; Sunday.Year <= year; Sunday = Sunday.AddDays(7))
			{
				Sundays.Add(Sunday);
			}
			foreach(DateTime Sunday in Sundays)
			{
				Console.WriteLine(Sunday);
			}
		}
	}
}
