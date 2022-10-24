using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	/// <summary>
	/// 在集合中移除多個項目
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			// 在集合中移除多個項目
			int[] source = { 3, 5, 7, 9, 11, 13 };
			int[] target = { 7, 11, 99 };
			// TODO result應該是{3,5,9,13}
			// var result 

			List<int> sourceList = new List<int>();

			foreach (int element in source)
			{
				sourceList.Add(element);
			}

			foreach (int element in target)
			{
				sourceList.Remove(element);
			}

			var result = sourceList;

			string list = string.Join(", ", result.Select(x => x.ToString()).ToArray());
			string msg = $"{{ 3,5,7,9,11,13}} 移除 {{ 7, 11, 99 }} 的結果為 {list}";
			Console.WriteLine(msg);
		}
	}
}