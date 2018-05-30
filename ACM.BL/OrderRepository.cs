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
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            //create the instance of the Order class
            //pass in the order id
            OrderDisplay orderDisplay = new OrderDisplay();

            //code that retrieves the defined order fields

            //temporary hard coded values to return
            //a populated order
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Glenn";
                orderDisplay.LastName = "Danzig";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Kitten Town",
                    StreetLine2 = "Kitten Circle",
                    City = "Hoboken",
                    State = "New Jersey",
                    Country = "United States",
                    PostalCode = "666"
                };
            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            //code that retrieves order item
            //temporary hard coded items
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sure Step Kitty Litter",
                    PurchasePrice = 16.99M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Litter Box Scooper",
                    PurchasePrice = 6M,
                    OrderQuantity = 1

                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
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
