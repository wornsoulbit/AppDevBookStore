using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    [Serializable]
    class BorrowedBooks {
        public string SerialNum { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Days { get; set; }
        public double Price { get; set; }

        public BorrowedBooks() { }

        public BorrowedBooks(string serialNum, string title, string author, int days, double price)
        {
            SerialNum = serialNum;
            Title = title;
            Author = author;
            Days = days;
            Price = price;
        }
    }
}
