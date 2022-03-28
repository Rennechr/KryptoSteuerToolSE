using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace KryptoSteuernTool
{
    public struct Saveable
    {
        public User user;
        public List<Transaction> transactions;
    }
    internal class Saver
    {
        public Saver()
        {
        }
        public void save(User user, List<Transaction> transactions)
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
                        Saveable saveable = new Saveable();
                        saveable.user = user;
                        saveable.transactions = transactions;
                        writer.Write(JsonSerializer.Serialize<Saveable>(saveable));
                    }
                    myStream.Close();
                }
            }
        }
    }
}