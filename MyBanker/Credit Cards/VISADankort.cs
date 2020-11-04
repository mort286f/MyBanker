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
            protected set { name = value; }
        }
        public override string CardNumber { get; protected set; }
        private int minAge;

        public override int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }

        private DateTime? expireDate;

        public override DateTime? ExpireDate
        {
            get { return expireDate; }
            protected set { expireDate = value; }
        }
        private long accountNumber;

        public override long AccountNumber
        {
            get { return accountNumber; }
            protected set { accountNumber = value; }
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
        //List that holds prefixes for all Visa Dancards
        private List<int> prefix = new List<int>() { 4 };
        public VISADankort(string name) : base(name)
        {
            this.CardNumber = GenerateCardNumber();
            this.ExpireDate = DateTime.Now.AddYears(5);
            this.MinAge = 18;
            this.MonthlyWithdraw = 25000;
            this.Kredit = 20000;
        }

        //Generates a random 16 long card number with prefix
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
