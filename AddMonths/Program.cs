using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMonths
{
	// 計算圖書下個月歸還時間
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime time = today.AddMonths(1);
			Console.WriteLine($"圖書歸還時間{time}");
		}
	}
}
