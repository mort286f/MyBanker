using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Mastercard : Card, ICreditcard
    {
        private string name;
        public override string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public override string CardNumber { get; protected set; }
        private int minaAge;

        public override int MinAge
        {
            get { return minaAge; }
            set { minaAge = value; }
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
        private int dailyWithdraw;

        public int DailyWithdraw
        {
            get { return dailyWithdraw; }
            set { dailyWithdraw = value; }
        }

        //List that contains all the prefixes for all Mastercards
        private List<int> prefix = new List<int>() { 51, 52, 53, 54, 55 };

        public Mastercard(string name) : base(name)
        {
            this.CardNumber = GenerateCardNumber();
            this.ExpireDate = DateTime.Now.AddYears(5);
            this.MonthlyWithdraw = 30000;
            this.DailyWithdraw = 5000;
            this.Kredit = 40000;

        }

        //Generates a random 16 long card number with prefix
        public override string GenerateCardNumber()
        {
            Random rndm = new Random();
            int number = rndm.Next(0, 4);
            CardNumber = prefix.ElementAt(number).ToString();
            for (int i = 0; i < 14; i++)
            {
                int nmbr = rndm.Next(0, 10);
                CardNumber += nmbr;
            }
            return CardNumber;
        }
    }
}
