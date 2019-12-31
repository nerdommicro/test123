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

        public Listing() {
            
        }
        public Listing(string title, double price)
        {
            Title = title;
            Price = price;
        }


    }
}
