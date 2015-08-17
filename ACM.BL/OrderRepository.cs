﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            //Create the instance of the Order Class
            //Pass in the requested Id
            Order order = new Order();

            //Code that retrieves the defined Order

            //Temporary hard coded values to return
            //a poopulated order
            if (orderId == 10)
            {
                order.OrderData = new DateTimeOffset();
            }

            return order;
        }
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //Code that retrieves the define fields

            //Temp hardcoded values
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot End",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }
            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            //Code that retrieves order items

            //Temp hardcoded data
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };

                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };

                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

            }
            return orderDisplay;
        }
        public bool Save()
        {
            //TBD
            return true;
        }
    }
}
