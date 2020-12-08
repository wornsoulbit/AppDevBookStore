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
    public partial class Member : Form
    {
        List<Customer> cList = new List<Customer>();
        List<BorrowedBooks> borrowList = new List<BorrowedBooks>();
        List<Book> bList = new List<Book>();
        BookStore bStore = new BookStore(1, 1, "Employee");

        int count = 0;

        SerializeDeserializeFile serializer = SerializeDeserializeFile.GetInstance();

        public Member()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int id = (int)IDnum.Value;
            String name = FnameTextbox.Text + " " + lnameTextbox.Text;
            String card = CardTextbox.Text;

            Customer c = new Customer(id, name, card);
            cList.Add(c);

            BookStoreInterface store = new BookStoreInterface(bList, bStore, cList, borrowList);

            serializer.SerializeObjects(store);

            IDnum.Value = IDnum.Minimum;
            FnameTextbox.Text = "";
            lnameTextbox.Text = "";
            CardTextbox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
