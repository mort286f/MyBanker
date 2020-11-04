using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface IAccount
    {
        string AccountNumber { get; set; }
        string GenerateAccountNumber();
    }
}
