using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Sell : Form
    {
        List<Book> bList = new List<Book>();

        public Sell()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            Code.SerializeDeserializeFile serializer = Code.SerializeDeserializeFile.GetInstance();

            List<Customer> cList = new List<Customer>();
            cList.Add(new Customer(0, "", ""));
            BookStore bStore = new BookStore(0, 0, "");

            Code.BookStoreInterface store = new Code.BookStoreInterface(bList, bStore, cList);

            serializer.SerializeObjects(store);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String bookName = BookNameTextbox.Text;
            String author = AuthorTextbox.Text;
            String SN = SnTextbox.Text;
            double price = (double)PriceUpDown.Value;

            BookNameTextbox.Text = "";
            AuthorTextbox.Text = "";
            SnTextbox.Text = "";
            PriceUpDown.Value = PriceUpDown.Minimum;

            bList.Add(new Book(bookName, author, SN, price));
        }
    }
}
