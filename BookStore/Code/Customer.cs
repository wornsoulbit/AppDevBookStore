using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    [Serializable]
    class Customer {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustCreditCard { get; set; }

        public Customer() { }
        
        public Customer(int custId, string custName, string custCreditCard) 
        {
            CustId = custId;
            CustName = custName;
            CustCreditCard = custCreditCard;
        }
    }
}
