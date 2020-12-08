using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    
    public partial class Main : Form
    {
        List<Book> bList = new List<Book>();
        int count = 0;

        SerializeDeserializeFile serializer = SerializeDeserializeFile.GetInstance();

        public Main()
        {
            InitializeComponent();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
        }

        private void StoreChooseButton_Click(object sender, EventArgs e)
        {
            serializer.DeserializeObjbects();
            bList = serializer.GetBookList();
            ShowDetails();
        }

        private void ShowDetails()
        {
            NameTextbox.Text = bList[count].Title;
            AuthorTextbox.Text = bList[count].Author;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int checker = bList.Count();
            checker--;
            if(count < checker)
            {
                count++;
                ShowDetails();
            }
            else
            {
                count = 0;
                ShowDetails();
            }

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            SerializeDeserializeFile serializer = SerializeDeserializeFile.GetInstance();

            List<Customer> cList = new List<Customer>();

            List<BorrowedBooks> borrowList = new List<BorrowedBooks>();

            List<Book> bList = new List<Book>();
            Book book = new Book("Test", "Test", "Test", 20.00);
            Customer cust = new Customer(3, "Justin", "123");

            cList.Add(cust);

            bList.Add(book);

            BookStore bStore = new BookStore(1, 3, "Son of a bitch");

            BookStoreInterface store = new BookStoreInterface(bList, bStore, cList, borrowList);

            serializer.SerializeObjects(store);
        }
    }
}
