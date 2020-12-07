using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    [Serializable]
    class Customer {
        private int custId;
        private string custName;

        public Customer() { }
        
        public Customer(int custId, string custName) { }
    }
}
