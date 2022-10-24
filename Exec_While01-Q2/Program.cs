using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While02
{
	/// <summary>
	/// 使用 while , 在畫面顯示所有可以整除 300 的整數, 例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int num = 1;
			while (num <= 300)
			{
				if (300 % num == 0)
				{
					Console.WriteLine(num);
				}
				num++;
			}
		}
	}
}