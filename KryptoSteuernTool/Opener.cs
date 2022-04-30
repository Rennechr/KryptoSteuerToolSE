using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace KryptoSteuernTool
{
    interface IOpenable
    {
        void open();
    }
    internal class Opener : IOpenable
    {
        public Opener()
        {

        }

        public void open()
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

                    User result = JsonSerializer.Deserialize<User>(fileContent, options);
                    MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
                    MainGUI.user = result;
                }
            }
        }
    }
}