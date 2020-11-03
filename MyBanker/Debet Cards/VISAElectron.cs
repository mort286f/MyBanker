using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VISAElectron : ICard, IDebetcard
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
        private List<int> prefix;
        public List<int> Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }
        private double maxAmount;
        public double MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
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

        public VISAElectron()
        {

        }

        public bool CheckExpireDate()
        {
            throw new NotImplementedException();
        }

        public string GenerateCardNumber()
        {
            throw new NotImplementedException();
        }
    }
}
