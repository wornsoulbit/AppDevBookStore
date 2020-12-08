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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            Code.SerializeDeserializeFile serializer = Code.SerializeDeserializeFile.GetInstance();

            List<Customer> cList = new List<Customer>();

            List<Book> bList = new List<Book>();

            cList.Add(new Customer(3, "Justin", "123"));

            bList.Add(new Book("Test", "Test", "Test", 20.00));

            BookStore bStore = new BookStore(1, 3, "Son of a bitch");

            Code.BookStoreInterface store = new Code.BookStoreInterface(bList, bStore, cList);

            serializer.SerializeObjects(store);
        }
    }
}
