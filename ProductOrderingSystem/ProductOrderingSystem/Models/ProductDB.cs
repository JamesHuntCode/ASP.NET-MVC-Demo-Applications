using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductOrderingSystem.Models
{
    public class ProductDB : DbContext
    {
        public DbSet<Models.Product>        Products        { get; set; }
        public DbSet<Models.Order>          Orders          { get; set; }
        public DbSet<Models.Order_Line>     Order_Lines     { get; set; }
    }
}