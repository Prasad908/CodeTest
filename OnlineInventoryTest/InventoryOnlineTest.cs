using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineInventory;
using OnlineInventory.Models;
using System.Collections.Generic;

namespace OnlineInventoryTest
{
    [TestClass]
    public class InventoryOnlineTest
    {
        private IInventory _productService;
        private Mock<IProductRepository> _mockProductRepository;
        private IOrderService _orderService;
        private IUserDetails _paymentGateway;


        [TestMethod]
        //[ExpectedException(typeof(ArgumentNullException)),"out of quantity")]
        public void Check_product_With_better_info()
        {
            var order = new Order
            {
                 //new Product{ProductId="101",ProductName="Product_2",Price=10m,Quantity=20},
                 //new Product {ProductId="100",ProductName="Product_1",Price=100m,Quantity=10},
                 //new Product {ProductId="101",ProductName="Product_2",Price=10m,Quantity=20},
                 //new Product {ProductId="102",ProductName="Product_3",Price=101m,Quantity=15},
                 //new Product {ProductId="103",ProductName="Product_4",Price=103m,Quantity=10},
                 //new Product {ProductId="104",ProductName="Product_5",Price=120m,Quantity=20},
                 //new Product {ProductId="105",ProductName="Product_6",Price=13m,Quantity=10},

                Product = new Product { ProductId = "101", Price = 10m, ProductName = "Product_1", Quantity = 15 },
                Quantity = 22,
                OrderId =  12,
                OrderNumber = "112psk",
            };
        }

        [TestMethod]
        // [ExpectedException(typeof(ArgumentNullException),"Check  number")]
        public void Test_userCard_details()
        {
            var userDetails = new UserDetails
            {
                CreditCardNumber = "2033451799",
                CvvNumber = "233",
                NameOnCard = "Customer Name",
                OrderId = 1025,
                UserId = 12
            };

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Product Not found")]
        public void Check_info_product_details()
        {
            //new Product{ProductId="101",ProductName="Product_2",Price=10m,Quantity=20},
            var order = new Order
            {
               Product=new Product { ProductId="102",Price=10m,ProductName="Product_2",Quantity=20 },
               Quantity=2,
               OrderId=10,
               OrderNumber="100P1"
                
            };

         //    _orderService = new OrderService()

            var NewOrder = _orderService.PlaceOrder(order);
            Assert.AreEqual(NewOrder, true);

        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException),"No product")]
        public void Test_info_to_orders()
        {
            var order = new Order
            {
                Product = new Product { ProductId = "1", Price = 10m, ProductName = "product_88", Quantity = 12 },
                Quantity = 4,
                OrderId = 22,
                OrderNumber = "1D3"

            };
            var PlacedOrder = _orderService.PlaceOrder(order);
            Assert.AreEqual(PlacedOrder, true);


        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"Please Check you Credit Card Number")]
        public void Test_payment_gateway()
        {

            var Order = new Order
            {

                Product = new Product { ProductId = "102", Price = 10m, ProductName = "Product_2", Quantity = 20 },
                Quantity = 2,
                OrderId = 10,
                OrderNumber = "100P1"

            };

            var placeOrder = _paymentGateway.ChargePayment("", 0);
            Assert.AreEqual(placeOrder, true);




        }






        [TestInitialize]
        public void Initialize()
        {
            _mockProductRepository = new Mock<IProductRepository>();
            // _product= new Product
            _productService = new ProductInventory(_mockProductRepository.Object);
            _orderService = new OrderService();
            _paymentGateway = new UserPaymentDetails();


            var products = new List<Product>
            {
                new Product  {ProductId="100",ProductName="Product_1",Price=100m,Quantity=10},
                 new Product {ProductId="101",ProductName="Product_2",Price=10m,Quantity=20},
                 new Product {ProductId="102",ProductName="Product_3",Price=101m,Quantity=15},
                 new Product {ProductId="103",ProductName="Product_4",Price=103m,Quantity=10},
                 new Product {ProductId="104",ProductName="Product_5",Price=120m,Quantity=20},
                 new Product {ProductId="105",ProductName="Product_6",Price=13m,Quantity=10},
            };
            _mockProductRepository.Setup(mock => mock.GetAllProducts()).Returns(products);
            //_mockProductRepository.Setup(mock=>mock.)

            //_mockEmployeeRepository.Setup(mock => mock.GetById(5))
            //    .Returns(employees.FirstOrDefault(e => e.Id == 5));
        
           
        }
    }

}
