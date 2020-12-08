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
    public partial class Borrow : Form
    {
        List<Customer> cList = new List<Customer>();
        List<BorrowedBooks> borrowList = new List<BorrowedBooks>();
        List<Book> bList = new List<Book>();
        BookStore bStore = new BookStore(1, 1, "Employee");

        int count = 0;

        SerializeDeserializeFile serializer = SerializeDeserializeFile.GetInstance();

        public Borrow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int days = (int)DaysNum.Value;
            BorrowedBooks b = new BorrowedBooks(bList[count].SerialNum, bList[count].Title, bList[count].Author, days, bList[count].Price);

            borrowList.Add(b);
            bList.Remove(bList[count]);

            BookStoreInterface store = new BookStoreInterface(bList, bStore, cList, borrowList);

            serializer.SerializeObjects(store);

            count = 0;
            ShowDetails();
        }

        private void ShowDetails()
        {
            NameTextbox.Text = bList[count].Title;
            AuthorTextbox.Text = bList[count].Author;
            SnTextbox.Text = bList[count].SerialNum;
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            serializer.DeserializeObjbects();
            cList = serializer.GetCustomerList();
            bList = serializer.GetBookList();
            borrowList = serializer.GetBorrowedBooks();
            ShowDetails();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int checker = bList.Count();
            checker--;
            if (count < checker)
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
    }
}
