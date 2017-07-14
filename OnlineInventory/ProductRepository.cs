using OnlineInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventory
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductByQuantity();
    }

    public class ProductRepository : IProductRepository
    {

        public List<Product> GetProductByQuantity()
        {
            return new List<Product>
            {
                 //new Product {ProductId="100",ProductName="Product_1",Price=100m,Quantity=10},
                 //new Product {ProductId="101",ProductName="Product_2",Price=10m,Quantity=20},
                 //new Product {ProductId="102",ProductName="Product_3",Price=101m,Quantity=15},
                 //new Product {ProductId="103",ProductName="Product_4",Price=103m,Quantity=10},
                 //new Product {ProductId="104",ProductName="Product_5",Price=120m,Quantity=20},
                 //new Product {ProductId="105",ProductName="Product_6",Price=13m,Quantity=10},

            };
        }

        public List<Product> GetAllProducts()

        {
            return new List<Product>
                {
                 new Product {ProductId="100",ProductName="Product_1",Price=100m,Quantity=10},
                 new Product {ProductId="101",ProductName="Product_2",Price=10m,Quantity=20},
                 new Product {ProductId="102",ProductName="Product_3",Price=101m,Quantity=15},
                 new Product {ProductId="103",ProductName="Product_4",Price=103m,Quantity=10},
                 new Product {ProductId="104",ProductName="Product_5",Price=120m,Quantity=20},
                 new Product {ProductId="105",ProductName="Product_6",Price=13m,Quantity=10},
                };

        }

        public List<Product> GetProductByPrice()
        {
            return new List<Product> { };
        
        }
    }

}       
       

