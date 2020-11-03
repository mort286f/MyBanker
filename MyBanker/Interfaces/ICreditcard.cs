using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface ICreditcard
    {
        public double Kredit { get; set; }
        public int MonthlyWithdraw { get; set; }
    }
}
