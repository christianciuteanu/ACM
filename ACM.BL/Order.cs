using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Order: EntityBase, ILoggable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderData { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (OrderData == null)
            {
                isValid = false;
            }
            return isValid;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
