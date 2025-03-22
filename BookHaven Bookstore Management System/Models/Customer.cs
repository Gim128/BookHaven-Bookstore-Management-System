using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Models
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string PurchaseHistory { get; set; }
    }
}
