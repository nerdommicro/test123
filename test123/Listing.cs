using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test123
{
    class Listing
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }

        public Listing() {
            
        }
        public Listing(string title, double price, int quantity)
        {
            Title = title;
            Price = price;
            Quantity = quantity;
        }
        public double calculateTotal(int quantity)
        {
            double totalQuantity;

            totalQuantity = quantity * Price;

            return totalQuantity;

        }


    }
}
