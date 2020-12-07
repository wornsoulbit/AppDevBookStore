using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BookStore.Code {
    class SerializeDeserializeFile {

        private static SerializeDeserializeFile serializeDeserialize;

        //Storing the deserialized outputs from the deserialization process.
        private List<Book> books = new List<Book>();
        private List<Customer> customers = new List<Customer>();
        private List<BookStore> bookStores = new List<BookStore>();

        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private FileStream input;

        public static SerializeDeserializeFile GetInstance()
        {
            if (serializeDeserialize == null)
            {
                CreateInstance();
            }
            return serializeDeserialize;
        }

        private static void CreateInstance()
        {
            serializeDeserialize = new SerializeDeserializeFile();
        }

        public void SerializeObjects(BookStoreInterface bookStoreInterface)
        {
            //Opens a dialog box to save to a file and create it if it doesn't exists.
            SaveToFileDialog();

            //Tries to Serialize the data to a given file.
            try
            {
                formatter.Serialize(output, bookStoreInterface);
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

        public void DeserializeObjbects()
        {
            OpenFileDialog();

            while (true)
            {
                try
                {
                    //Deserializes book objects.
                    BookStoreInterface bookStoreInterface = (BookStoreInterface)formatter.Deserialize(input);

                    foreach (Book book in bookStoreInterface.Book)
                    {
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

                    //Deserializes Customer objects.
                    foreach (Customer cust in bookStoreInterface.Customer)
                    {
                        if (cust.CustId > 0)
                        {
                            string[] values = new string[]
                            {
                            cust.CustId.ToString(),
                            cust.CustName.ToString(),
                            cust.CustCreditCard.ToString()
                            };

                            customers.Add(new Customer(Int32.Parse(values[0]), values[1], values[2]));
                        }
                    }

                    //Deserializes BookStore objects.
                    if (bookStoreInterface.BookStore.BookSerialNum != string.Empty)
                    {
                        string[] values = new string[]
                        {
                            bookStoreInterface.BookStore.BookSerialNum.ToString(),
                            bookStoreInterface.BookStore.BookId.ToString(),
                            bookStoreInterface.BookStore.CustId.ToString()
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
        //Probably will be replaced need to test the new methods 
        //DO NOT REMOVE until new methods are tested.
        #region Serializing Objects
        private void SerializeBooks(List<Book> books)
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

        private void SerializeCustomers(List<Customer> customers)
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

        private void SerializeBookStore(List<BookStore> bookStores)
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
        //end comment.
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
