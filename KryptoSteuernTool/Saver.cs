using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace KryptoSteuernTool
{
    interface ISaveable
    {
        void save(User user);
    }
    internal class Saver : ISaveable
    {
        public Saver()
        {
        }
        void ISaveable.save(User user)
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
    }
}