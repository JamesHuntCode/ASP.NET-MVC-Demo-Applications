using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductOrderingSystem.Models
{
    public class Order_Line
    {
        public int      Order_LineID        { get; set; }
        public int      Order_Number        { get; set; }
        public int      Quanitity           { get; set; }
        public int      ProductID           { get; set; }
    }
}