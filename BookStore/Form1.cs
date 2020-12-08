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
        Code.SerializeDeserializeFile serializer = Code.SerializeDeserializeFile.GetInstance();
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
            BookStore bStore = serializer.DeserializeObjbects();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
