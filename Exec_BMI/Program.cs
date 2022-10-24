using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
	/// <summary>
	/// 計算 BMI
	/// BMI值計算公式:    BMI = 體重(公斤) / 身高2(公尺2)
	/// 體重過輕 BMI ＜ 18.5
	/// 正常範圍 18.5≦BMI＜24
	/// 過重：24≦BMI＜27
	/// 輕度肥胖：27≦BMI＜30
	/// 中度肥胖：30≦BMI＜35
	/// 重度肥胖：BMI≧35　
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入你的體重:　");
			int weight = Convert.ToInt32(Console.ReadLine());
			Console.Write("請輸入你的身高: ");
			float height = Convert.ToSingle(Console.ReadLine()) / 100;

			float BMI = weight / (float)Math.Pow(height, 2);
			//Console.WriteLine(BMI);
			string result = string.Empty;
			List<string> BMIList = new List<string>() { "體重過輕", "正常範圍", "過重", "輕度肥胖", "中度肥胖", "重度肥胖" };

			//if(BMI < 27)
			//{
			//	if(BMI < 18.5)
			//	{
			//		result = BMIList[0];
			//	}
			//	else
			//	{
			//		if(BMI < 24)
			//		{
			//			result = BMIList[1];
			//		}
			//		else
			//		{
			//			result = BMIList[2];
			//		}
			//	}
			//}
			//else
			//{
			//	if(BMI < 30)
			//	{
			//		result = BMIList[3];
			//	}
			//	else
			//	{
			//		if(BMI < 35)
			//		{
			//			result = BMIList[4];
			//		}
			//		else
			//		{
			//			result = BMIList[5];
			//		}
			//	}
			//}

			List<double> BMIvalues = new List<double>() { 18.5, 24, 27, 30, 35 };
			for (int i = 0; i < 4; i++)
			{
				if (BMI < BMIvalues[i])
				{
					result = BMIList[i];
					break;
				}
			}

			Console.WriteLine($"您的BMI是{BMI}," + result);

		}
	}
}

