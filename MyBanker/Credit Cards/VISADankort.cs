using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VISADankort : ICard, ICreditcard
    {
        #region Properties
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
        #endregion

        public VISADankort()
        {

        }

        public string GenerateCardNumber()
        {
            throw new NotImplementedException();
        }
    }
}
