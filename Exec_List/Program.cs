using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
	/// <summary>
	/// 宣告一個 List<Product> 變數, 存放多筆購買商品
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = new List<Product>()
			{
				new Product() { Id = 1, ProductName = "Phone", Price = 39900},
				new Product() { Id = 2, ProductName = "Mouse", Price = 2340},
				new Product() { Id = 3, ProductName = "Cup", Price = 300},
			};

			foreach (Product product in products)
			{
				Console.WriteLine($"{product.Id}\t{product.ProductName}\t{product.Price}");
			}
		}
	}

	public class Product
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public int Price { get; set; }
	}
}