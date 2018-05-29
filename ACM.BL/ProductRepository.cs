using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //create the instance of the Product class
            //pass in requested Id
            Product product = new Product(productId);

            //code that retrieves the defined customer

            //temporary hard coded values to return
            //a populated product
            if (productId == 1)
            {
                product.ProductName = "Danzig II";
                product.ProductDescription = "Quite possible Danzig's best album.";
                product.CurrentPrice = 29.99m;
            }

            return product;
        }

        /// <summary>
        /// Saves the current product 
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves defined product
            return true;
        }
    }
}
