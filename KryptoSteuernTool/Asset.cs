﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    internal class Asset
    {
        public string kuerzel;
        public decimal amount;

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
