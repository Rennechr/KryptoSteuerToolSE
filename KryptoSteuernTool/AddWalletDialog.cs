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
        public Panel txPanel;
        public AddWalletDialog()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            string[] rules = {"required"};
            if (validator.check(rules, textBoxName))
            {
                if (MainGUI.user == null)
                {
                    MainGUI.user = new User();
                }
                MainGUI.user.addWallet(textBoxName.Text);
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

        
        private void AddWalletDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
