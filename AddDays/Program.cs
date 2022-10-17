using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDays
{
	internal class Program
	{
		// 計算三天後 DVD 應歸還時間
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime time = today.AddDays(3);
			Console.WriteLine($"DVD歸還時間{time}");
		}
	}
}
