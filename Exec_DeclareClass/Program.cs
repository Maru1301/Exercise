using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}

	class Address
	{
		private string _City;
		public string City 
		{ 
			get => _City; 
			set => _City = value; 
		}

		private string _ZipCode;
		public string ZipCode 
		{ 
			get => ZipCode; 
			set => ZipCode = value; 
		}

		private string _Street;
		public string Street 
		{ 
			get => _Street; 
			set => _Street = value; 
		}
	}

	class Telephone
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

		private string _Number;
		public string Number 
		{ 
			get => _Number; 
			set => _Number = value; 
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
		private string _Name;
		public string Name 
		{ 
			get => _Name; 
			set => _Name = value; 
		}
		private string _Account;
		public string Account 
		{ 
			get => _Account;
			set => _Account = value; 
		}
		private string _Password;
		public string Password 
		{ 
			get => _Password; 
			set => _Password = value; 
		}
		private string _Email;
		public string Email 
		{ 
			get => _Email; 
			set => _Email = value; 
		}
		private Address _Address;
		public Address Address 
		{ 
			get => _Address; 
			set => _Address = value; 
		}
		private string _Cellphone;
		public string Cellphone 
		{ 
			get => _Cellphone; 
			set => _Cellphone = value; 
		}
		private Telephone _Telephone;
		public Telephone Telephone 
		{ 
			get => _Telephone; 
			set => _Telephone = value; 
		}

		public void Register(string Name, string Account, string Password, string confirmPassword, string Email)
		{
			if(Password != confirmPassword)
			{
				throw new Exception("Your password and confirm password are not the same!");
			}
				this.Name = Name;
				this.Account = Account;
				this.Password = Password;
				this.Email = Email;
		}

		public string ForgetPassword(string Name, string Email)
		{
			if (Name != this.Name) throw new Exception("Wrong name!");
			if (Email != this.Email) throw new Exception("Wrong e-mail!");

			return Password;
		}

		public bool Authenticate(string Account, string Password)
		{
			if (Account != this.Account) throw new Exception("Wrong account");
			if (Password != this.Password) throw new Exception("Wrong Password");

			return true;
		}
	}
}
