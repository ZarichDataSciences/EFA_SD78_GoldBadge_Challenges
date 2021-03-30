using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBBQ
{
    public class FoodSalesRepo
    {
        public int NumberHamburgersServed { get; set; }
        public int NumberHotDogsServed { get; set; }
        public int NumberVeggieBurgersServed { get; set; }
        public int NumberIceCreamServed { get; set; }
        public int NumberPopcornBagsServed { get; set; }
        public int CostOfPopcorn { get; set; }
        
        public decimal CostOfPackaging = .25m; //set at 25 cents for all packaging and condiments for all products
    }
}
