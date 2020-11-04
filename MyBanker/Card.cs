using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        public abstract string Name { get; protected set; }
        public abstract string CardNumber { get; protected set; }
        public abstract DateTime? ExpireDate { get; protected set; }
        public abstract long AccountNumber { get; protected set; }
        public abstract int MinAge { get; set; }

        public abstract string GenerateCardNumber();

        public Card(string name)
        {
            this.Name = name;
        }
    }
}
