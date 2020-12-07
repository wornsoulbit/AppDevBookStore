using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Code {
    class SerializeDeserializeFile {
        
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private FileStream input;

        #region Serializing Objects
        public void SerializeBooks(List<Book> books)
        {
            //Opens a dialog box to save to a file and create it if it doesn't exists.
            SaveToFileDialog();

            //Tries to Serialize the data to a given file.
            try
            {
                foreach (Book book in books) {
                    formatter.Serialize(output, book);
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SerializeCustomers(List<Customer> customers)
        {
            //Opens a dialog box to save to a file and create it if it doesn't exists.
            SaveToFileDialog();

            //Tries to Serialize the data to a given file.
            try
            {
                foreach (Customer cust in customers)
                {
                    formatter.Serialize(output, cust);
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SerializeBookStore(List<BookStore> bookStores)
        {
            //Opens a dialog box to save to a file and create it if it doesn't exists.
            SaveToFileDialog();

            //Tries to Serialize the data to a given file.
            try
            {
                foreach (BookStore bookStore in bookStores)
                {
                    formatter.Serialize(output, bookStore);
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Deserializing Objects
        public void DeserializeBooks()
        {
            //Gets the file to deserialize from.
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {

                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                }
            }
        }
        #endregion
        public void SaveToFileDialog()
        {
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChoser = new SaveFileDialog())
            {
                fileChoser.CheckFileExists = false;

                result = fileChoser.ShowDialog();
                fileName = fileChoser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
