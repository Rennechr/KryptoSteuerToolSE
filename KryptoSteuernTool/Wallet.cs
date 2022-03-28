using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    public partial class Wallet
    {
        public string name { get; set; }

        public string address { get; set; }
        public List<Asset> assets { get; set; }

        public Wallet(string newName, List<Asset> newAssets)
        {
            assets = newAssets;
            name = newName;
        }
        public Wallet(string newName)
        {
            assets = new List<Asset>();
            name = newName;
        }

        public Wallet()
        {
            assets = new List<Asset>();
        }
        public void reciveAsset(string assetName)
        {
            if(!assetExists(assetName))
            {
                assets.Add(new Asset(assetName));
            }
            else
            {
                //do nothing
            }
        }

        public void reciveAsset(string assetName, decimal amountNumber)
        {
            if (!assetExists(assetName))
            {
                assets.Add(new Asset(assetName, amountNumber));
            }
            else
            {
                assets.Where(item => item.kuerzel == assetName).First().changeAmount(amountNumber);
            }
        }

        public bool assetExists(string assetName)
        {
            return assets.Where(item => item.kuerzel == assetName).Count() == 0 ? false : true;
        }
    }
}
