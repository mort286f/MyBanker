using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private ulong cardNumber;

        public ulong CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
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

        public Card(string name, ulong cardNumber, string expireDate, long accountNumber, List<int> prefix)
        {
            this.Name = name;
            this.CardNumber = cardNumber;
            this.ExpireDate = expireDate;
            this.AccountNumber = accountNumber;
            this.Prefix = prefix;
        }
    }
}
