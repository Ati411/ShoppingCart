using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class MenuItem
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public bool isChecked { get; set; }


        public double GetTotalPrice()
        {
            return price * quantity;
        }


        public double GetDiscount(double discountPercentage)
        {
            return GetTotalPrice() * (discountPercentage / 100);
        }
    }
}