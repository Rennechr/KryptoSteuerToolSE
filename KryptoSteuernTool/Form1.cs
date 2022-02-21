using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KryptoSteuernTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            User user = new User("Peter");
            user.addWallet("Peters Binance");
            user.deposit("Peters Binance", "XCH", 300);

            user.wallets.Where(x=>x.name == "Peters Binance").First().reciveAsset("XCH", 100);

            user.wallets.Where(x => x.name == "Peters Binance").First().reciveAsset("BTC", 1);

            user.wallets.Where(x => x.name == "Peters Binance").First().reciveAsset("BTC", -0.5m);

            user.withdrawl("Peters Binance", "XCH", 300);
        }
    }
}
