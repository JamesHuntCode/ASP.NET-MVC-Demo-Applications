using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductOrderingSystem.Models
{
    public class Order
    {
        public int                      Order_Number        { get; set; }
        public DateTime                 Order_Date          { get; set; }
        public ICollection<Order_Line>  Order_Lines         { get; set; }
    }
}