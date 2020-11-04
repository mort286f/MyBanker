using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Maestro : Card, IDebetcard
    {
        private string name;
        public override string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public override string CardNumber { get; protected set; }
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
        private double maxMonthly;
        public double MaxMonthly
        {
            get { return maxMonthly; }
            set { maxMonthly = value; }
        }
        private int minAge;
        public override int MinAge
        {
            get { return minAge; }
            set { minAge = value; }
        }
        private bool isUsableInternational;
        public bool IsUsableInternational
        {
            get { return isUsableInternational; }
            set { isUsableInternational = value; }
        }
        private bool isUsableOnNet;
        public bool IsUsableOnNet
        {
            get { return isUsableOnNet; }
            set { isUsableOnNet = value; }
        }
        //List containing prefixes for Maestro cards
        private List<int> prefix = new List<int>() { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
        public Maestro(string name) : base(name)
        {
            
            this.CardNumber = GenerateCardNumber();
            this.ExpireDate = DateTime.Now.AddYears(5).AddMonths(8);
            this.MinAge = 18;
            this.MaxMonthly = 0;
            this.IsUsableInternational = true;
            this.IsUsableOnNet = true;
        }

        //Generates a random 19 long card number with prefix
        public override string GenerateCardNumber()
        {
            Random rndm = new Random();
            int number = rndm.Next(0, 8);
            CardNumber = prefix.ElementAt(number).ToString();
            for (int i = 0; i < 15; i++)
            {
                int nmbr = rndm.Next(0, 10);
                CardNumber += nmbr;
            }
            return CardNumber;
        }
    }
}
