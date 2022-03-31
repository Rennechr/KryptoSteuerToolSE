using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    public partial struct Trade{
        public Asset assetFrom { get; set; }
        public Asset assetTo { get; set; }
        public Wallet wallet { get; set; }
    }
    public partial struct Send
    {
        public Asset asset { get; set; }
        public string walletFrom { get; set; }
        public string walletTo { get; set; }
    }
    public partial class Transaction
    {
        public Trade trade { get; set; }
        public Send send { get; set; }
        DateTime time;

        public Transaction(Trade trade)
        {
            this.trade = trade;
        }
        public Transaction(Send send)
        {
            this.send = send;
        }
        public Transaction()
        {
            this.trade = new Trade();
            this.send = new Send();
        }
    }
}
