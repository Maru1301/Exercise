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
			int year = Convert.ToInt32(Console.ReadLine());
			DateTime[] Sundays = new DateTime[0];
			int index = 0;

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
					dayofweek = 0;
				}
			}
			firstSunday = firstSunday.AddDays(difference);

			for (DateTime Sunday = firstSunday; Sunday.Year <= year; Sunday = Sunday.AddDays(7), index++)
			{
				Array.Resize(ref Sundays, index + 1);
				Sundays[index] = Sunday;
				Console.WriteLine(Sundays[index]);
			}
		}
	}
}
