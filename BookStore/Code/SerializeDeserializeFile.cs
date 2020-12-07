using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BookStore.Code {
    class SerializeDeserializeFile {

        SerializeDeserializeFile serializeDeserialize;

        //Storing the deserialized outputs from the deserialization process.
        private List<Book> books = new List<Book>();
        private List<Customer> customers = new List<Customer>();
        private List<BookStore> bookStores = new List<BookStore>();

        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private FileStream input;

        public SerializeDeserializeFile getInstance()
        {
            if (serializeDeserialize == null)
            {
                createInstance();
            }

            return serializeDeserialize;
        }

        private SerializeDeserializeFile createInstance()
        {
            return new SerializeDeserializeFile();
        }

        #region Serializing Objects
        public void SerializeBooks(List<Book> books)
        {
            //Opens a dialog box to save to a file and create it if it doesn't exists.
            SaveToFileDialog();

            //Tries to Serialize the data to a given file.
            try
            {
                foreach (Book book in books)
                {
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
            OpenFileDialog();

            while (true)
            {
                try
                {
                    Book book = (Book)formatter.Deserialize(input);

                    if (book.SerialNum != string.Empty)
                    {
                        string[] values = new string[]
                        {
                            book.SerialNum.ToString(),
                            book.Title.ToString(),
                            book.Author.ToString(),
                            book.Price.ToString()
                        };

                        books.Add(new Book(values[0], values[1], values[2], Double.Parse(values[3])));
                    }
                }
                catch (SerializationException)
                {
                    input.Close();
                    MessageBox.Show("No more records in file", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        public void DeserializeCustomers()
        {
            OpenFileDialog();

            while (true)
            {
                try
                {
                    Customer book = (Customer)formatter.Deserialize(input);

                    if (book.CustId > 0)
                    {
                        string[] values = new string[]
                        {
                            book.CustId.ToString(),
                            book.CustName.ToString(),
                            book.CustCreditCard.ToString()
                        };

                        customers.Add(new Customer(Int32.Parse(values[0]), values[1], values[2]));
                    }
                }
                catch (SerializationException)
                {
                    input.Close();
                    MessageBox.Show("No more records in file", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        public void DeserializeBookStore()
        {
            OpenFileDialog();

            while (true)
            {
                try
                {
                    BookStore book = (BookStore)formatter.Deserialize(input);

                    if (book.BookSerialNum != string.Empty)
                    {
                        string[] values = new string[]
                        {
                            book.BookSerialNum.ToString(),
                            book.BookId.ToString(),
                            book.CustId.ToString()
                        };

                        bookStores.Add(new BookStore(Int32.Parse(values[2]), Int32.Parse(values[1]), values[0]));
                    }
                }
                catch (SerializationException)
                {
                    input.Close();
                    MessageBox.Show("No more records in file", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        #endregion

        public void OpenFileDialog()
        {
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
