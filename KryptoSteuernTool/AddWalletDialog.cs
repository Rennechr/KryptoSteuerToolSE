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
    public partial class AddWalletDialog : Form
    {
        public AddWalletDialog()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            string[] rules = {"required","singleRadioSelected"};
            if (validator.check(rules, textBoxName, groupBoxTransactionImport))
            {
                if (Form1.user == null)
                {
                    Form1.user = new User();
                }
                Form1.user.addWallet(textBoxName.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Validation Error");

            }
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
