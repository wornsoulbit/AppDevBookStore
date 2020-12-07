using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    [Serializable]
    class Book {
        private string serialNum;
        private string title;
        private string author;
        private double price;

        public Book()
        {

        }

        public Book(string serialNum, string title, string author, double price)
        {
            this.serialNum = serialNum;
            this.title = title;
            this.author = author;
            this.price = price;
        }

    }
}
