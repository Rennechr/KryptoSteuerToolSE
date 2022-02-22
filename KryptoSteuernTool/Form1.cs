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
        User user { get; set;}
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
            string fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "tax files (*.tax)|*.tax";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    };

                    var result = JsonSerializer.Deserialize<User>(fileContent,options);
                    user = result;

                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "tax files (*.tax)|*.tax";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(myStream))
                    {
                        writer.Write(JsonSerializer.Serialize<User>(user));
                    }
                    myStream.Close();
                }
            }
        }

        private void btnWalletAdd_Click(object sender, EventArgs e)
        {
            user.addWallet("Peters Binance");
        }
    }
}
