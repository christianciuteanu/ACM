﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
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

        public bool Validate()
        {
            var isValid = true;
            if (OrderData == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
