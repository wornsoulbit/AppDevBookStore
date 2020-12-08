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
        List<Customer> cList = new List<Customer>();
        List<BorrowedBooks> borrowList = new List<BorrowedBooks>();
        List<Book> bList = new List<Book>();
        BookStore bStore = new BookStore(1, 1, "Employee");

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
            SnTextbox.Text = bList[count].SerialNum;
            PriceTextbox.Text = bList[count].Price.ToString();
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
            Book book = new Book(bList[count].SerialNum, bList[count].Title, bList[count].Author, bList[count].Price);

            bList.Remove(book);

            BookStoreInterface store = new BookStoreInterface(bList, bStore, cList, borrowList);

            serializer.SerializeObjects(store);

            count = 0;
            ShowDetails();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
