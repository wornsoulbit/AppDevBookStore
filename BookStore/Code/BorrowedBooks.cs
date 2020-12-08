using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Code
{
    [Serializable]
    class BorrowedBooks
    {
        public string SerialNum { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Days { get; set; }

        public BorrowedBooks() { }

        public BorrowedBooks(String serialNum, String title, String author, int days)
        {
            SerialNum = serialNum;
            Title = Title;
            Author = author;
            Days = days;
        }
    }
}
