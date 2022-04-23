using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    public partial class Transaction
    {
        public Trade trade { get; set; }
        public Send send { get; set; }
        public DateTime time { get; set; }

        public Transaction(Trade trade, DateTime time)
        {
            this.trade = trade;
            this.time = time;
        }
        public Transaction(Send send, DateTime time)
        {
            this.send = send;
            this.time = time;
        }
        public Transaction()
        {
            this.send = new Send();
            this.trade = new Trade();
        }
    }
}
