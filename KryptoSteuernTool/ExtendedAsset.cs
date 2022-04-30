using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    internal class ExtendedAsset : Asset
    {
        
        public string discription { get; set; }

        public ExtendedAsset(string kuerzelName, decimal amountNumber, string assetDiscription) : base(kuerzelName, amountNumber)
        {
            kuerzel = kuerzelName;
            amount = amountNumber;
            discription = assetDiscription;
        }
        public ExtendedAsset(string kuerzelName, decimal amountNumber) : base(kuerzelName, amountNumber)
        {
            kuerzel = kuerzelName;
            amount = amountNumber;
        }
        public ExtendedAsset(string kuerzelName) : base(kuerzelName)
        {
            kuerzel = kuerzelName;
            amount = 0;
        }

        public string getAssetInfo()
        {
            return kuerzel + " " + amount.ToString() + " " + discription;
        }
        
    }
}
