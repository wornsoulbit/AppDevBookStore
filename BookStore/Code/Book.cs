using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    [Serializable]
    class Book {
        public string SerialNum { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book() { }

        public Book(string serialNum, string title, string author, double price) { }

    }
}
