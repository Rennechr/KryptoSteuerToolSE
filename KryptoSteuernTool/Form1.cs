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
        public static User user { get; set; }
        public List<Transaction> transactions { get; set; }

        List<Label> walletNames = new List<Label>();
        List<Button> walletButtons = new List<Button>();
        List<Label> walletAmount = new List<Label>();
        List<Label> assetName = new List<Label>();
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
            Saveable saveable = new Saveable();
            Opener opener = new Opener();
            saveable = opener.open();
            user = saveable.user;
            transactions= saveable.transactions;
            updateWalletList();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            saver.save(user, transactions);
        }

        private void btnWalletAdd_Click(object sender, EventArgs e)
        {
            
            using (AddWalletDialog addWalletDialog = new AddWalletDialog())
            {
                addWalletDialog.ShowDialog();
                if(addWalletDialog.DialogResult == DialogResult.OK)
                {
                    updateWalletList();
                }
            }
        }

        public void updateWalletList()
        {
            int i = 0;
            foreach(Wallet wallet in user.wallets)
            {
                walletNames.Add(new Label());
                walletNames.Last().Text = wallet.name;
                walletNames.Last().AutoSize = true;
                walletNames.Last().BackColor = Color.White;
                walletNames.Last().Location = new Point(20, 30*i+20);
                walletButtons.Add(new Button());
                walletButtons.Last().Text = "Show";
                walletButtons.Last().AutoSize = true;
                walletButtons.Last().Location = new Point(120, 30 * i + 20);
                walletButtons.Last().Click += (sender, e) => showWallet(sender, e, i);
                groupBox1.Controls.Add(walletButtons.Last());
                groupBox1.Controls.Add(walletNames.Last());

                i++;
            }
        }
        void showWallet(object sender, EventArgs e, int i)
        {
            i = i - 1;
            int count = 0;
            if(user.wallets.ElementAt(i).assets.Count() == 0)
            {
                assetName.Add(new Label());
                assetName.Last().Text = "Diese Wallet enthält noch keine Assets";
                assetName.Last().AutoSize = true;
                assetName.Last().Location = new Point(20, 30 * count + 20);
                groupBoxTransactions.Controls.Add(assetName.Last());
            }
            else
            {
                foreach (Asset asset in user.wallets.ElementAt(i).assets)
                {
                    assetName.Add(new Label());
                    assetName.Last().Text = asset.kuerzel;
                    assetName.Last().AutoSize = true;
                    assetName.Last().Location = new Point(20, 30 * count + 60);
                    groupBoxTransactions.Controls.Add(assetName.Last());
                    count++;
                }
            }
            if(transactions != null)
            {
                Button btn = new Button();
                btn.Text = "Transaktionen Anzeigen";
                btn.Location = new Point(120, 60);
                btn.AutoSize = true;
                groupBoxTransactions.Controls.Add(btn);
                btn.Click += (sender2, e2) => showTransactions(sender, e, i);
            }
            //add new Form To show Wallet Specific stuff
        }
        void showTransactions(object sender, EventArgs e, int i)
        {
            int count = 0; 
            Wallet wallet = user.wallets.ElementAt(i);

            foreach(Transaction transaction in user.transactions)
            {
                if (transaction.trade.wallet == wallet)
                {
                    Label label = new Label();
                    label.Text = "Traded from " + transaction.trade.assetFrom.ToString() + " to " + transaction.trade.assetTo.ToString();
                    label.Location = new Point(20, 30 * count + 30);
                    label.AutoSize = true;
                    groupBoxTransactions.Controls.Add(label);

                    count++;
                }
                else if (transaction.send.walletFrom == wallet || transaction.send.walletTo == wallet)
                {
                    Label label = new Label();
                    label.Text = "Send " + transaction.send.asset.ToString() + " from " + transaction.send.walletFrom.ToString() + " to " + transaction.send.walletTo.ToString();
                    label.Location = new Point(20, 30 * count + 30);
                    label.AutoSize = true;
                    groupBoxTransactions.Controls.Add(label);

                    count++;
                }
                else
                {
                    //skip
                }

            }
        }

    }
}
