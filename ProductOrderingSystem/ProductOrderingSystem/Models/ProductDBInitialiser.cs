using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace ProductOrderingSystem.Models
{
    public class ProductDBInitialiser : CreateDatabaseIfNotExists<ProductDB>
    {
        protected override void Seed(ProductDB context)
        {
            context.Products.AddOrUpdate(
                p => p.ProductID,
                new Product { Product_Code = "A123", Product_Name = "Ball point pens", Stock = 200, Price = (float)0.20 },
                new Product { Product_Code = "A127", Product_Name = "Fountain pens", Stock = 100, Price = (float)1.20 }
             );

            context.Orders.AddOrUpdate(
                o => o.Order_Number,
                new Order { Order_Number = 1, Order_Date = DateTime.Now }
             );

            context.SaveChanges();

            //Gather the products into a dictionary, but output from the product code the product ID.
            var Products = context.Products.ToDictionary(p => p.Product_Code, p => p.ProductID);

            context.Order_Lines.AddOrUpdate(
                 new Order_Line { Order_Number = 1, ProductID = Products["A123"], Quantity = 2 }, 
                 new Order_Line { Order_Number = 1, ProductID = Products["A127"], Quantity = 1 }
             );

            context.SaveChanges();
        }
    }
}