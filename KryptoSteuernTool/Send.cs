using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSteuernTool
{
    public class Send
    {
        public Asset asset { get; set; }
        public string walletFrom { get; set; }
        public string walletTo { get; set; }
    }
}
