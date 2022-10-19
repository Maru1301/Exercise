using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Pow
{
	/// <summary>
	/// 有一個數值,是四位數, 左邊二位的數字相同, 右邊二位的數字相同
	/// 這個四位數值, 剛好也是某整數的平方, 請問這個四位數值是什麼?
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int thousands = 0, hundreds = 0, tens = 0, ones = 0, pow = 0;

			for (int i = (int)Math.Sqrt(1000); i < 100; i++)
			{
				pow = (int)Math.Pow(i, 2);
				int temp = pow;
				thousands = temp / 1000;
				temp %= 1000;
				hundreds = temp / 100;
				if (thousands == hundreds)
				{
					temp %= 100;
					tens = temp / 10;
					temp %= 10;
					ones = temp / 1;
					if (tens == ones)
					{
						Console.WriteLine(pow);
						break;
					}
				}
			}
		}
	}
}
