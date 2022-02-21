using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    internal class Wallet
    {
        private string APIPublic;
        private string APISecret;

        public string name;
        public List<Asset> assets = new List<Asset>();

        public Wallet(string newName)
        {
            name = newName;
        }

        Wallet(string newName, string APIPublickey, string APISecretKey)
        {
            name = newName;
            APIPublic = APIPublickey;
            APISecret = APISecretKey;
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
