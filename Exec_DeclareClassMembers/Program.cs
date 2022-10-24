using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClassMembers03
{
	/// <summary>
	/// 將指定文字內容存檔, 由於要存放的文字內容與檔案存放位置都會變化, 所以我們可以將這兩項資訊設計成 method 的參數, 由外界傳入
	/// 請設計一個FileManager class, 內含一個 Save method, 只需要設定method,不必實作出功能
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
		}

		internal class FileManager
		{
			void Save(string text, string path)
			{
				throw new NotImplementedException();
			}
		}
	}
}
