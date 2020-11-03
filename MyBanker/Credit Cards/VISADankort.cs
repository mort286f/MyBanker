using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VISADankort : Card, ICreditcard
    {
        private string name;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string CardNumber { get; set; }
        private DateTime? expireDate;

        public override DateTime? ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        private long accountNumber;

        public override long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
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
        private List<int> prefix = new List<int>() { 4 };
        public VISADankort(string name) : base(name)
        {
            this.CardNumber = GenerateCardNumber();
            this.ExpireDate = DateTime.Now.AddYears(5);
        }

        public override string GenerateCardNumber()
        {
            Random rndm = new Random();
            CardNumber = prefix.ElementAt(0).ToString();
            for (int i = 0; i < 15; i++)
            {
                int nmbr = rndm.Next(0, 10);
                CardNumber += nmbr;
            }
            return CardNumber;
        }
    }
}
