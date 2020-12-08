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
        private List<BorrowedBooks> borrowBooks = new List<BorrowedBooks>();

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

        public List<Book> GetBookList()
        {
            return books;
        }

        public List<Customer> GetCustomerList()
        {
            return customers;
        }

        public List<BookStore> GetBookStores()
        {
            return bookStores;
        }

        public List<BorrowedBooks> GetBorrowedBooks()
        {
            return borrowBooks;
        }

        public void SerializeObjects(BookStoreInterface bookStoreInterface)
        {
            //Opens a dialog box to save to a file and create it if it doesn't exists.
            SaveToFileDialog();

            //Tries to Serialize the data to a given file.
            try
            {
                if (output != null)
                {
                    formatter.Serialize(output, bookStoreInterface);
                } 
                else
                {
                    return;
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
            output.Close();
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
                    
                    foreach (BorrowedBooks book in bookStoreInterface.Borrow)
                    {
                        string[] values = new string[]
                        {
                            book.SerialNum.ToString(),
                            book.Title.ToString(),
                            book.Author.ToString(),
                            book.Days.ToString()
                        };

                        borrowBooks.Add(new BorrowedBooks(values[0], values[1], values[2], Int32.Parse(values[3])));
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
                    //MessageBox.Show("No more records in file", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        
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
