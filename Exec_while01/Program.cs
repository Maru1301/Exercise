using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01
{
	/// <summary>
	/// 1+ 2 + 3 + 4 + .... + N <105, 請問 N 是多少?
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int N = 1, sum = N;
			while (sum < 105)
			{
				N++;
				sum += N;
			}
			N--;

			Console.WriteLine(N);
		}
	}
}
