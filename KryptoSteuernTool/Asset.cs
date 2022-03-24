using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    public partial class Asset
    {
        public string kuerzel { get; set; }
        public decimal amount { get; set; }

        public Asset(string kuerzelName)
        {
            kuerzel = kuerzelName;
            amount = 0;
        }

        public Asset(string kuerzelName, decimal amountNumber)
        {
            kuerzel = kuerzelName;
            amount = amountNumber;
        }

        public decimal changeAmount(decimal amountNumber)
        {
            amount += amountNumber;
            return amount;
        }
    }
}
