using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    [Serializable]
    class BookStore {
        private int bookId;
        private int custId;
        private string bookSerialNum;

        public BookStore() { }

        public BookStore(int bookId, int custId, string bookSerialNum) { }
    }
}
