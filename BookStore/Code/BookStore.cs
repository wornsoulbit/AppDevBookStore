using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    [Serializable]
    class BookStore {
        public int BookId { get; set; }
        public int CustId { get; set; }
        public string BookSerialNum { get; set; }

        public BookStore() { }

        public BookStore(int bookId, int custId, string bookSerialNum) { }
    }
}
