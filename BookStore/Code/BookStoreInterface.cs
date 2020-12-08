using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    [Serializable]
    class BookStoreInterface
    {
        public List<Book> Book { get; set; }
        public BookStore BookStore { get; set; }
        public List<Customer> Customer { get; set; }
        public List<BorrowedBooks> Borrow { get; set; }

        public BookStoreInterface() { }

        public BookStoreInterface(List<Book> book, BookStore bookStore, List<Customer> customer, List<BorrowedBooks> borrow) 
        { 
            Book = book; 
            BookStore = bookStore;
            Customer = customer;
            Borrow = borrow;
        }
    }
}
