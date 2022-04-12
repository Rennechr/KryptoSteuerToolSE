using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    public partial class User
    {
        public string username { get; set; }
        public List<Wallet> wallets { get; set; }
        public List<Transaction> transactions { get; set; }

        public User()
        {
            wallets = new List<Wallet>();
            transactions = new List<Transaction>();
        }


        public User(string newUsername, List<Wallet> newWallets)
        {
            transactions = new List<Transaction>();
            wallets = newWallets;
            username = newUsername;
        }
       
        public User(string newUsername)
        {
            wallets = new List<Wallet>();
            transactions = new List<Transaction>();
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
