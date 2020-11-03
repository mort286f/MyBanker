using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Mastercard : ICard, ICreditcard
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string CardNumber { get; set; }
        private string expireDate;
        public string ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        private long accountNumber;
        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        private List<int> Prefix = new List<int>() { 51, 52, 53, 54, 55 };
        private double kredit;
        public double Kredit
        {
            get { return kredit; }
            set { kredit = value; }
        }
        private int monthlyWithdraw;
        public int MonthlyWithdraw
        {
            get { return monthlyWithdraw; }
            set { monthlyWithdraw = value; }
        }

        public Mastercard()
        {

        }

        public string GenerateCardNumber()
        {
            Random rndm = new Random();
            int number = rndm.Next(0, 4);
            CardNumber = Prefix.ElementAt(number).ToString();
            for (int i = 0; i < 14; i++)
            {
                int nmbr = rndm.Next(0, 10);
                CardNumber += nmbr;
            }
            return CardNumber;
        }
    }
}
