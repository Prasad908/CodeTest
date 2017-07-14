
using OnlineInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory
{
    public interface IOrderService
    {
        bool PlaceOrder( Order order );
       // bool checkOrderInfo(UserDetails Details);
    }

    public class OrderService:IOrderService
    {
        public readonly IInventory _order;
        public readonly Email _mail;
        public readonly UserPaymentDetails _cardDetails;

        //public OrderService(IInventory ProductRepository)
        //{
        //    _mail = new Email();
        //    _order = new ProductInventory(new ProductRepository());
        //    _cardDetails = new UserPaymentDetails();
        //}

        public OrderService()
        {    //I'm just using parameterized constructor
            
            _mail = new Email();
            _order = new ProductInventory(new ProductRepository());
            _cardDetails = new UserPaymentDetails();
        }
        public bool PlaceOrder(Order order)
        {
            if (order.Product != null)
            {
                var userProduct = _order.CheckInventory(order.Product.Quantity, order.Product.ProductId);
                    if (userProduct)
                {
                    _cardDetails.ChargePayment(order.UserDetail.CreditCardNumber, order.Product.Price);
                    _mail.SendEmail(order);
                    return true;
                }
             }
            throw new Exception("Product not found :"); 

        }

    }




}



