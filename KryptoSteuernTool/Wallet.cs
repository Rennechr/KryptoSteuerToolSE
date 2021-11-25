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

        public void reciveAsset(Asset asset)
        {
            Console.WriteLine(assets.Where(item => item.kuerzel == asset.kuerzel));
        }
    }
}
