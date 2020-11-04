using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Account : IAccount
    {
		private string accountNumber;
		public string AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}
		private int registrationNumber = 3520;
		public Account(string name)
		{
			this.AccountNumber = GenerateAccountNumber();


		}

		//Generate a 14 long account number with a prefix
		public string GenerateAccountNumber()
		{
			Random rndm = new Random();
			AccountNumber = registrationNumber.ToString();
			for (int i = 0; i < 10; i++)
			{
				int nmbr = rndm.Next(0, 10);
				AccountNumber += nmbr;
			}
			return AccountNumber;
		}
	}
}
