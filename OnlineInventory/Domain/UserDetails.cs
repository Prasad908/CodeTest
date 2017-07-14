using OnlineInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory.Models
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public int OrderId { get; set; }

        // Credit Card Details 

        public string CreditCardNumber { get; set; }

        public string NameOnCard { get; set; }

        public string CvvNumber { get; set; }

        

    }
}
