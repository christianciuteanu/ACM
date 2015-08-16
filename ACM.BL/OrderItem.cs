using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchesPrice { get; set; }

        public OrderItem Retrieve(int orderItemID) 
        {
            //TBD
            return new OrderItem();
        }

        public bool Save() 
        {
            //TBD
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0)
            {
                isValid = false;
            }
            if (ProductId <= 0)
            {
                isValid = false;
            }
            if (PurchesPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
