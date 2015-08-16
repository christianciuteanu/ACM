using System;
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
        public bool Save()
        {
            //TBD
            return true;
        }
    }
}
