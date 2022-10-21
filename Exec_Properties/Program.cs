using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Properties
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}

		struct Address
		{
			private string _CityName;
			public string CityName
			{
				get => _CityName;
				set => _CityName = value;
			}

			private string _TownShip;
			public string TownShip
			{
				get => _TownShip;
				set => _TownShip = value;
			}

			private string _ZipCode;
			public string ZipCode
			{
				get => _ZipCode;
				set => _ZipCode = value;
			}

			private string _Street;
			public string Street
			{
				get => _Street;
				set => _Street = value;
			}
		}
		struct Telephone
		{
			private string _CountryCode;
			public string CountryCode
			{
				get => _CountryCode;
				set => _CountryCode = value;
			}

			private string _AreaCode;
			public string AreaCode
			{
				get => _AreaCode;
				set => _AreaCode = value;

			}

			private string _PhoneNumber;
			public string PhoneNumber
			{
				get => _PhoneNumber;
				set => _PhoneNumber = value;
			}

			private string _Ext;
			public string Ext
			{
				get => _Ext;
				set => _Ext = value;
			}
		}
		class Member
		{
			private string _Id;
			public string Id
			{
				get => _Id;
				set => _Id = value;
			}

			private string _Name;
			public string Name
			{
				get => _Name;
				set => _Name = value;
			}

			private string _Email;
			public string Email
			{
				get => _Email;
				set => _Email = value;
			}

			private DateTime _Birthday;
			public DateTime Birthday
			{
				get => _Birthday;
				set => _Birthday = value;
			}

			private Address _Address;
			public Address Address
			{
				get => _Address;
				set => _Address = value;
			}

			private Telephone _Tel_home;
			public Telephone Tel_home
			{
				get => _Tel_home;
				set => _Tel_home = value;
			}

			private Telephone _Tel_office;
			public Telephone Tel_office
			{
				get => _Tel_office;
				set => _Tel_office = value;
			}
		}
	}
	/*
	 * 建立 struct , 名稱是 Address , 內含以下屬性
- 城市名稱( city name)
- 鄉鎮名稱( township)
- 郵遞區號(zip code)
- 街道名(street)
---
建立 struct, 名稱是 Telephone, 內含以下屬性
- 國際區碼(country code)
- 區碼(area code)
- 號碼(phone number)
- 分機(ext)
---
建立 class, 名稱是 Member , 內含以下屬性
- 編號( id)
- 姓名(name)
- Email
- 生日( birthday)
- 地址(address), 型別是上方的 Address
- 住家電話(tel_home), 型別是上方的 Telephone
- 辦公室電話(tel_office), 型別是上方的 Telephone
	 */
}