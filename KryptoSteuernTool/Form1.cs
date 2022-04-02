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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Opener opener = new Opener();
            user = opener.open();
            updateWalletList();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Saver saver = new Saver();
            saver.save(user);
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
            groupBox1.Controls.Clear();
            int i = 0;
            foreach(Wallet wallet in user.wallets)
            {
                int local_i = i;
                Label lblWalletName = new Label();
                lblWalletName.Text = wallet.name;
                lblWalletName.AutoSize = true;
                lblWalletName.BackColor = Color.White;
                lblWalletName.Location = new Point(20, 30*i+20);
                Button btnShowWallet = new Button();
                btnShowWallet.Text = "Show";
                btnShowWallet.AutoSize = true;
                btnShowWallet.Location = new Point(120, 30 * i + 20);
                btnShowWallet.Click += (sender, e) => showWallet(sender, e, local_i);
                groupBox1.Controls.Add(btnShowWallet);
                groupBox1.Controls.Add(lblWalletName);
                i++;
            }
        }
        void showWallet(object sender, EventArgs e, int i)
        {
            groupBoxTransactions.Controls.Clear();
            int count = 0;
            if(user.wallets.ElementAt(i).assets.Count() == 0)
            {
                Label lblNoAssets = new Label();
                lblNoAssets.Text = "Diese Wallet enthält noch keine Assets";
                lblNoAssets.AutoSize = true;
                lblNoAssets.Location = new Point(20, 30 * count + 20);
                groupBoxTransactions.Controls.Add(lblNoAssets);
            }
            else
            {
                foreach (Asset asset in user.wallets.ElementAt(i).assets)
                {
                    Label lblAssetName = new Label();
                    lblAssetName.Text = asset.kuerzel + " | " +  asset.amount.ToString();
                    lblAssetName.AutoSize = true;
                    lblAssetName.Location = new Point(20, 30 * count + 60);
                    groupBoxTransactions.Controls.Add(lblAssetName);
                    count++;
                }
            }
            if(user.transactions.Count()>0)
            {
                Button btn = new Button();
                btn.Text = "Transaktionen Anzeigen";
                btn.Location = new Point(120, 60);
                btn.AutoSize = true;
                groupBoxTransactions.Controls.Add(btn);
                btn.Click += (sender2, e2) => showTransactions(sender, e, i);
            }
            Button btnAddTx = new Button();
            btnAddTx.Text = "Transaktionen Hinzufügen";
            btnAddTx.Location = new Point(20, 80+30*count);
            btnAddTx.AutoSize = true;
            groupBoxTransactions.Controls.Add(btnAddTx);
            btnAddTx.Click += (sender2, e2) => addTransactions(sender, e, i);
            //add new Form To show Wallet Specific stuff
        }
        void addTransactions(object sender, EventArgs e, int i)
        {
            AddTransactionsDialog addTransactionsDialog = new AddTransactionsDialog();  
            addTransactionsDialog.ShowDialog();
        }
        void showTransactions(object sender, EventArgs e, int i)
        {
            int count = 0; 
            Wallet wallet = user.wallets.ElementAt(i);

            foreach(Transaction transaction in user.transactions)
            {
                if (transaction.trade.wallet == wallet.name)
                {
                    Label label = new Label();
                    label.Text = "Traded from " + transaction.trade.assetFrom.ToString() + " to " + transaction.trade.assetTo.ToString();
                    label.Location = new Point(20, 30 * count + 30);
                    label.AutoSize = true;
                    groupBoxTransactions.Controls.Add(label);

                    count++;
                }
                else if (transaction.send.walletFrom == wallet.name || transaction.send.walletTo == wallet.name)
                {
                    Label label = new Label();
                    label.Text = "Send " + transaction.send.asset.amount + " " + transaction.send.asset.kuerzel + " from " + transaction.send.walletFrom.ToString() + " to " + transaction.send.walletTo.ToString();
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
