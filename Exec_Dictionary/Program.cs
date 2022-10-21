using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Dictionary
{
	/// <summary>
	/// 統計陣列中, 每一個字串出現次數
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "A,C,A,B,B,A,D";
			string[] items = value.Split(',');
			Array.Sort(items);
			// TODO 統計陣列中, 每一個字串出現次數
			//Console.WriteLine(items[0].GetType());
			Dictionary<string, int> itemCount = new Dictionary<string, int>();
			foreach (string item in items)
			{
				if (itemCount.ContainsKey(item))
				{
					itemCount[item]++;
				}
				else
				{
					itemCount.Add(item, 1);
				}
			}
			foreach (KeyValuePair<string, int> item in itemCount)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}
	}
}
