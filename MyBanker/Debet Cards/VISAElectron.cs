using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VISAElectron : Card, IDebetcard
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
        private double maxMonthly;
        public double MaxMonthly
        {
            get { return maxMonthly; }
            set { maxMonthly = value; }
        }

        private int minAge;
        public int MinAge
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
        private List<int> prefix = new List<int>() { 4026, 417500, 4508, 4844, 4913, 4917 };
        public VISAElectron(string name) : base(name)
        {
            this.CardNumber = GenerateCardNumber();
            this.ExpireDate = DateTime.Now.AddYears(5);
            this.MinAge = 15;
            this.MaxMonthly = 10000;
            this.IsUsableInternational = true;
            this.IsUsableOnNet = true;
        }

        public override string GenerateCardNumber()
        {
            Random rndm = new Random();
            int number = rndm.Next(0, 5);
            CardNumber = prefix.ElementAt(number).ToString();
            if (number == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    int nmbr = rndm.Next(0, 10);
                    CardNumber += nmbr;
                }
            }
            else
            {

                for (int i = 0; i < 12; i++)
                {
                    int nmbr = rndm.Next(0, 10);
                    CardNumber += nmbr;
                }
            }
            return CardNumber;
        }
    }
}
