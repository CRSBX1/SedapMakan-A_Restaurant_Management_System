using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapMakan
{
    public class Order
    {
        public long orderId { get; set; }
        public DateTime orderDate { get; set; }
        public string status { get; set; }
        public decimal totalPrice { get; set; }
        public long userId { get; set; }  // customer who made the order
    }

}
