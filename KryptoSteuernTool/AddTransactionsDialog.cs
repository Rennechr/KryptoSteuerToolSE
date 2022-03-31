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
    class ComboItem
    {
        public int ID { get; set; }
        public string Text { get; set; }
    }
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
            items2.Add("Bank Account/Credit Card");
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

        }
        void loadCSV()
        {
            labelTitle.Text = "Import CSV";

        }
        void loadAPI()
        {
            labelTitle.Text = "Add With API";
        }
    }
}
