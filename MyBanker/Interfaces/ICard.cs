using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface ICard
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string ExpireDate { get; set; }
        public long AccountNumber { get; set; }
        public string GenerateCardNumber();
    }
}
