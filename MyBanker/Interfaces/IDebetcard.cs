using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface IDebetcard
    {
        public double MaxAmount { get; set; }
        public int MinAge { get; set; }
        public bool IsUsableInternational { get; set; }
        public bool IsUsableOnNet { get; set; }
    }
}
