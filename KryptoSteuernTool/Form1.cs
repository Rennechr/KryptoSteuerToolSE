using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace KryptoSteuernTool
{
    public partial class Form1 : Form
    {
        User user { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           /*
            user.deposit("Peters Binance", "XCH", 300);

            user.wallets.Where(x=>x.name == "Peters Binance").First().reciveAsset("XCH", 100);

            user.wallets.Where(x => x.name == "Peters Binance").First().reciveAsset("BTC", 1);

            user.wallets.Where(x => x.name == "Peters Binance").First().reciveAsset("BTC", -0.5m);

            user.withdrawl("Peters Binance", "XCH", 300);
           */
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Opener opener = new Opener();
            user = opener.open();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            saver.Save(user);
        }

        private void btnWalletAdd_Click(object sender, EventArgs e)
        {
            if(user == null) {
                user = new User();
            }
            user.addWallet("Peters Binance");
        }
    }
}
