using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KryptoSteuernTool
{
    public partial class AddTransactionsDialog : Form
    {
        public AddTransactionsDialog()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            string[] rules = { "radioSingleSelect" };
            if(validator.check(rules, groupBoxAddType))
            {
                panel1.Controls.Clear();
                if (radioButtonMaual.Checked)
                {
                    loadManual();
                }
                else if (radioButtonCSV.Checked)
                {
                    loadCSV();
                }
                else if (radioButtonAPI.Checked)
                {
                    loadAPI();
                }
            }
        }
        void loadManual()
        {
            labelTitle.Text = "Add Manual";
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Transaction Type";
            groupBox.Location = new Point(20, 20);
            groupBox.AutoSize = true;
            panel1.Controls.Add(groupBox);
            RadioButton rbSend = new RadioButton();
            RadioButton rbTrade = new RadioButton();
            rbSend.Text = "Add Deposit/Withdrawl";
            rbTrade.Text = "Add Trade";
            rbSend.AutoSize = true;
            rbTrade.AutoSize= true;
            rbTrade.Location = new Point(20, 20);
            rbSend.Location = new Point(20, 40);
            groupBox.Controls.Add(rbSend);
            groupBox.Controls.Add(rbTrade);

            rbSend.CheckedChanged += (sender2, e2) => addSend(sender2, e2);
            rbTrade.CheckedChanged += (sender2, e2) => addTrade(sender2, e2);

            

        }
        void addSend(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = "Wallet From";
            lbl.AutoSize = true;
            lbl.Location = new Point(20, 20);
            panel1.Controls.Add(lbl);

            ComboBox cb = new ComboBox();
            cb.Location = new Point(20, 40);
            cb.Width = 200;
            List<string> items = new List<string>();
            foreach (Wallet wallet in Form1.user.wallets)
            {
                items.Add(wallet.name);
            }
            items.Add("Bank Account/Credit Card");
            cb.DataSource = items;
            panel1.Controls.Add(cb);

            Label lbl2 = new Label();
            lbl2.Text = "Coin Kuerzel";
            lbl2.AutoSize = true;
            lbl2.Location = new Point(20, 60);
            panel1.Controls.Add(lbl2);

            TextBox txtKuerzel = new TextBox();
            txtKuerzel.Location = new Point(100, 60);
            panel1.Controls.Add(txtKuerzel);


            Label lbl3 = new Label();
            lbl3.Text = "Wallet To";
            lbl3.AutoSize = true;
            lbl3.Location = new Point(20, 80);
            panel1.Controls.Add(lbl3);

            ComboBox cb2 = new ComboBox();
            cb2.Location = new Point(20, 100);
            cb2.Width = 200;

            List<string> items2 = new List<string>();
            foreach (Wallet wallet in Form1.user.wallets)
            {
                items2.Add(wallet.name);
            }
            cb2.DataSource = items2;
            panel1.Controls.Add(cb2);

            Label lbl4 = new Label();
            lbl4.Text = "Coin Amount";
            lbl4.AutoSize = true;
            lbl4.Location = new Point(20, 120);
            panel1.Controls.Add(lbl4);

            TextBox txtAmount = new TextBox();
            txtAmount.Location = new Point(100, 120);
            panel1.Controls.Add(txtAmount);

            Button btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Location = new Point(20, 140);
            panel1.Controls.Add((Button)btnAdd);
            btnAdd.Click += (sender2, e2) =>
            {
                Form1.user.wallets.Find(wallet => wallet.name == cb.Text).reciveAsset(txtKuerzel.Text, -Decimal.Parse(txtAmount.Text));
                Form1.user.wallets.Find(wallet => wallet.name == cb2.Text).reciveAsset(txtKuerzel.Text, Decimal.Parse(txtAmount.Text));
                Send send = new Send();
                send.walletFrom = cb.Text;
                send.walletTo = cb2.Text;
                send.asset = new Asset(txtKuerzel.Text, Decimal.Parse(txtAmount.Text));

                Form1.user.transactions.Add(new Transaction(send));
            };
        }
        void addTrade(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = "Wallet";
            lbl.AutoSize = true;
            lbl.Location = new Point(20, 20);
            panel1.Controls.Add(lbl);

            ComboBox cb = new ComboBox();
            cb.Location = new Point(60, 20);
            cb.Width = 200;
            List<string> items = new List<string>();
            foreach (Wallet wallet in Form1.user.wallets)
            {
                items.Add(wallet.name);
            }
            cb.DataSource = items;
            panel1.Controls.Add(cb);

            Label lbl2 = new Label();
            lbl2.Text = "From Coin";
            lbl2.AutoSize = true;
            lbl2.Location = new Point(20, 50);
            panel1.Controls.Add(lbl2);
            TextBox txtKuerzel = new TextBox();
            txtKuerzel.Location = new Point(70, 50);
            panel1.Controls.Add(txtKuerzel);
            Label lbl3 = new Label();
            lbl3.Text = "Amount Coin";
            lbl3.AutoSize = true;
            lbl3.Location = new Point(150, 50);
            panel1.Controls.Add(lbl3);
            TextBox txtAmount = new TextBox();
            txtAmount.Location = new Point(190, 50);
            panel1.Controls.Add(txtAmount);

            Label lbl4 = new Label();
            lbl4.Text = "To Coin";
            lbl4.AutoSize = true;
            lbl4.Location = new Point(20, 80);
            panel1.Controls.Add(lbl4);
            TextBox txtKuerzel2 = new TextBox();
            txtKuerzel2.Location = new Point(70, 80);
            panel1.Controls.Add(txtKuerzel2);
            Label lbl5 = new Label();
            lbl5.Text = "Amount Coin";
            lbl5.AutoSize = true;
            lbl5.Location = new Point(150, 80);
            panel1.Controls.Add(lbl5);
            TextBox txtAmount2 = new TextBox();
            txtAmount2.Location = new Point(190, 80);
            panel1.Controls.Add(txtAmount2);

            Button btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Location = new Point(20, 140);
            panel1.Controls.Add((Button)btnAdd);
            btnAdd.Click += (sender2, e2) =>
            {
                Form1.user.wallets.Find(wallet => wallet.name == cb.Text).reciveAsset(txtKuerzel.Text, -Decimal.Parse(txtAmount.Text));
                Form1.user.wallets.Find(wallet => wallet.name == cb.Text).reciveAsset(txtKuerzel2.Text, Decimal.Parse(txtAmount2.Text));

                Trade trade =new Trade();
                trade.wallet = cb.Text;
                trade.assetFrom = new Asset(txtKuerzel.Text, Decimal.Parse(txtAmount.Text));
                trade.assetTo = new Asset(txtKuerzel2.Text, Decimal.Parse(txtAmount2.Text));

                Form1.user.transactions.Add(new Transaction(trade));
                MessageBox.Show("Successfully added Trade\n from " + txtAmount.Text + txtKuerzel.Text + " to " + txtAmount2.Text + txtKuerzel2.Text);
            };

        }
        void loadCSV()
        {
            labelTitle.Text = "Import CSV";

            string fileContent = string.Empty;
            var filePath = string.Empty;

            List<List<string>> list = new List<List<string>>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        bool first = true;
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(';');
                            if (first)
                            {
                                for(int i = 0; i<values.Length; i++)
                                {
                                    list.Add(new List<string>());
                                }
                                first = false;
                            }

                            for(int i = 0; i < values.Length; i++)
                            {
                                list.ElementAt(i).Add(values[i]);
                            }
                        }
                        reader.Close();
                    }
                }
            }
            
            panel1.Controls.Clear();

            Label lblInfo = new Label();
            lblInfo.Text = "Bitte wählen sie zu den vorgegebenen werten die passenden csv spalten aus";
            lblInfo.Location = new Point(20, 20);
            lblInfo.AutoSize = true;
            panel1.Controls.Add(lblInfo);
            List<string> comboItems = new List<string>();
            int count = 0;
            foreach(var item in list)
            { 
                comboItems.Add(list.ElementAt(count).ElementAt(1));
                count++;
            }

            List<ComboBox> cbs = new List<ComboBox>();
            List<Label> lbls = new List<Label>();
            for (int i = 0; i < 5; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20 + 100 * i, 50);
                lbl.AutoSize = true;
                lbls.Add(lbl);
                ComboBox cb = new ComboBox();
                cb.Location = new Point(20 + 100 * i, 80);
                cb.Width = 90;
                cb.BindingContext = new BindingContext();
                cb.DataSource = comboItems;
                cbs.Add(cb);
            }
            lbls.ElementAt(0).Text = "Timestamp";
            lbls.ElementAt(1).Text = "Coin From";
            lbls.ElementAt(2).Text = "Coin To";
            lbls.ElementAt(3).Text = "Amount From";
            lbls.ElementAt(4).Text = "Amount To";

            foreach (var lbl in lbls)
            {
                panel1.Controls.Add(lbl);
            }
            foreach(var cb in cbs)
            {
                panel1.Controls.Add(cb);
            }

            Button btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Location = new Point(20, 120);
            panel1.Controls.Add((Button)btnAdd);
            btnAdd.Click += (sender2, e2) =>
            {
                List<List<string>> tx = new List<List<string>>();
                foreach (var attribute in list)
                {
                    if (cbs.Where(a => a.Text == attribute.ElementAt(1)).Any())
                    {
                        tx.Add(attribute);
                    }
                }

            };
        }
        void loadAPI()
        {
            labelTitle.Text = "Add With API";
        }
    }
}
