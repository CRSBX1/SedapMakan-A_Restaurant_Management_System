using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapMakan
{
    public class OrderItem
    {
        public long orderItemsId { get; set; }
        public long orderId { get; set; }
        public long menuId { get; set; }
        public long preparedBy { get; set; }
    }

}
