using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Account
    {
		private string accountNumber;
		public string AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}
		private int registrationNumber = 3520;
		public Account()
		{
			this.AccountNumber = GenerateAcountNumber();
		}

		public string GenerateAcountNumber()
		{
			Random rndm = new Random();
			AccountNumber = registrationNumber.ToString();
			for (int i = 0; i < 14; i++)
			{
				int nmbr = rndm.Next(0, 10);
				AccountNumber += nmbr;
			}
			return AccountNumber;
		}
	}
}
