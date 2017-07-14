using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineInventory
{

    //user odering the Product from Inventory using given methods.

    public interface IInventory
    {
        bool CheckInventory(int Quantity, string productId);
      //  bool CheckInventory(decimal price, string productId);
    }

    public class UserOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check the Orders:");
        }

    }

    public class ProductInventory : IInventory
    {
        // User Ordering the new Order.

        public readonly IProductRepository _NewOrder;
         
        public ProductInventory(IProductRepository NewOrder)
            {
                    _NewOrder = NewOrder;
            }

        public bool CheckInventory(int qty, string productId)
        {
            var UserOrder = _NewOrder.GetAllProducts().FirstOrDefault(uo => uo.ProductId == productId);
            if (UserOrder == null)
            {
                throw new ApplicationException("No product");

            }

            var Qty = _NewOrder.GetAllProducts().Where(uq => uq.Quantity == qty && uq.Quantity<=UserOrder.Quantity );
            if (Qty.Any())
            {
                Console.WriteLine(" The Product is available:",productId  );
                return true;
            }
            Console.WriteLine("Please wait for next update:");
            return false;

        }    
          

    }
}
