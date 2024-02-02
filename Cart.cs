using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMakeUpStore
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId {  get; set; }

        public Dictionary<int, Product> productsInCart = new Dictionary<int, Product>();

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;

            foreach (var product in productsInCart.Values)
            {
                totalCost += product.Price;
            }

            return totalCost;
        }
    }


   
}
