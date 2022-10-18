using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			Console.WriteLine($"現在時間 {now}");

			int hour = now.Hour;

			if(hour <= 12)
			{
				Console.WriteLine("早安");
			}
			else if(hour <= 18)
			{
				Console.WriteLine("午安");
			}
			else
			{
				Console.WriteLine("晚安");
			}
		}
	}
}
