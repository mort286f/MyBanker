using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard mastercard = new Mastercard();
            Console.WriteLine(mastercard.GenerateCardNumber());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
