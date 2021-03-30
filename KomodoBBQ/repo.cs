using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBBQ
{
    public class FoodSalesRepo
    {
        // other repo held 'objects'
        // this repo just holds numbers
        public int NumberHamburgersServed { get; set; }
        public int NumberHotDogsServed { get; set; }
        public int NumberVeggieBurgersServed { get; set; }
        public int NumberIceCreamServed { get; set; }
        public int NumberPopcornBagsServed { get; set; }


        public decimal CostOfPopcorn = 2.5m;
        public decimal CostOfHamburger = 4.5m;
        public decimal CostOfIceCream = 2.5m;
        public decimal CostOfHotDog = 2.75m;
        public decimal CostOfVeggieBurger = 115.93m; //No one likes vegitarians so....

        public decimal CostOfPackaging = .25m; //set at 25 cents for all packaging and condiments for all products
    }
}
