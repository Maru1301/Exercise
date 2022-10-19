using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int Cock = 1, Hen = 0, Chicken = 0;
			//Brute force
			//for(Cock = 1; Cock < 20; Cock++)
			//{
			//	for(Hen = 0; Hen < 33; Hen++)
			//	{
			//		Chicken = 100 - (Cock + Hen);

			//		if (Chicken % 3 == 0 && (Cock * 5 + Hen * 3 + Chicken / 3) == 100)
			//		{
			//			Console.WriteLine($"公雞 {Cock} 隻，母雞 {Hen} 隻，小雞 {Chicken} 隻");
			//		}
			//	}
			//}

			//Advence
			for(int i = 1; i <= 3; i++)
			{
				Cock = 4 * i;
				Hen = 25 - 7 * i;
				Chicken = 75 + 3 * i;

				if((Cock + Hen + Chicken) == 100)
				{
					Console.WriteLine($"公雞 {Cock} 隻，母雞 {Hen} 隻，小雞 {Chicken} 隻");
				}
			}
		}
	}
}
