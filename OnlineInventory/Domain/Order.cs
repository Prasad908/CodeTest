using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory.Models
{
  public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set;}

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public UserDetails UserDetail { get; set; }
    }
}
