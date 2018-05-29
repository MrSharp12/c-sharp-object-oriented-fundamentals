using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //create the instance of the Order class
            //pass in the order id
            Order order = new Order(orderId);

            //code that retrieves the defined customer

            //temporary hard coded values to return
            //a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018,);
            }

            return order;
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves a defined order
            return true;
        }
    }
}
