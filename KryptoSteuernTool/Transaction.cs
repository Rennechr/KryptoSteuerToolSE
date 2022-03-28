using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    public struct Trade{
        public Asset assetFrom;
        public Asset assetTo;
        public Wallet wallet;
    }
    public struct Send
    {
        public Asset asset;
        public Wallet walletFrom;
        public Wallet walletTo;
    }
    public partial class Transaction
    {
        public Trade trade;
        public Send send;
        DateTime time;

        Transaction(Trade trade)
        {
            this.trade = trade;
        }
        Transaction(Send send)
        {
            this.send = send;
        }
    }
}
