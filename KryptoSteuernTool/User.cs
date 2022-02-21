using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    internal class User
    {
        public string username;
        public List<Wallet> wallets = new List<Wallet>();

        public User(string newUsername)
        {
            username = newUsername;
        }

        public void addWallet(string name)
        {
            wallets.Add(new Wallet(name));
        }
        public void deposit(string walletName, string assetName, decimal amountNumber)
        {
            wallets.Where(x => x.name == walletName).First().reciveAsset(assetName, amountNumber);
        }

        public void withdrawl(string walletName, string assetName, decimal amountNumber)
        {
            wallets.Where(x => x.name == walletName).First().reciveAsset(assetName, (amountNumber * -1));
        }

    }
}
