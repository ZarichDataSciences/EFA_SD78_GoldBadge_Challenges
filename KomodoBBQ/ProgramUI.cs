using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBBQ
{
    class ProgramUI
    {
        FoodSalesRepo repo = new FoodSalesRepo(); 

        public void Run()
        {
            while (true)
            {
                Console.WriteLine(
                    "Type (1) to sell whamburger\n" +
                    "Type (2) to sell a VeggieBurger\n" +
                    "Type (3) to sell a hotdog\n" +
                    "Type (4) to sell a IceCream\n" +
                    "Type (5) to sell a Popcorn\n" + 
                    "Type (6) to display total sales and revenue\n" +
                    "Type (0) to exit the program"
                );

                string userInput = Console.ReadLine();
                if (userInput == "0")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else if (userInput == "1")
                {
                    repo.NumberHamburgersServed++;
                }
                else if (userInput == "2")
                {
                    repo.NumberVeggieBurgersServed++; 
                }
                else if (userInput == "3")
                {
                    repo.NumberHotDogsServed++;
                }
                else if (userInput == "4")
                {
                    repo.NumberIceCreamServed++;
                }
                else if (userInput == "5")
                {
                    repo.NumberPopcornBagsServed++; 
                }
                else if (userInput == "6")
                {
                    DisplayCostOfItemsSold("popcorn");
                    DisplayCostOfItemsSold("hamburger");
                    DisplayCostOfItemsSold("ice_cream");
                    DisplayCostOfItemsSold("hot_dog");
                    DisplayCostOfItemsSold("veggie_burger");
                }
                else
                {
                    Console.WriteLine("Please enter valid selection.");
                }
            }
        }

        void DisplayCostOfItemsSold(string item_type)
        {
            if (item_type == "popcorn")
            {
                Console.WriteLine("total popcorn sold (" + repo.NumberPopcornBagsServed + " units) is: $"
                    + ((repo.NumberPopcornBagsServed * repo.CostOfPopcorn) + (repo.NumberPopcornBagsServed * repo.CostOfPackaging)));
            } 
            else if (item_type == "hamburger")
            {
                Console.WriteLine("total cost of hamburgers sold (" + repo.NumberHamburgersServed + " units) is: $" 
                    + ((repo.NumberHamburgersServed * repo.CostOfHamburger) + (repo.NumberHamburgersServed * repo.CostOfPackaging)));
            }
            else if (item_type == "ice_cream")
            {
                Console.WriteLine("total cost of ice creams sold (" + repo.NumberIceCreamServed + " units) is: $"
                    + ((repo.NumberIceCreamServed * repo.CostOfIceCream) + (repo.NumberIceCreamServed * repo.CostOfPackaging)));
            }
            else if (item_type == "hot_dog")
            {
                Console.WriteLine("total cost of hot dogs sold (" + repo.NumberHotDogsServed + " units) is: $"
                    + ((repo.NumberHotDogsServed * repo.CostOfHotDog) + (repo.NumberHotDogsServed * repo.CostOfPackaging)));
            }
            else if (item_type == "veggie_burger")
            {
                Console.WriteLine("total cost of veggie burgers sold (" + repo.NumberVeggieBurgersServed + " units) is: $"
                    + ((repo.NumberVeggieBurgersServed * repo.CostOfVeggieBurger) + (repo.NumberVeggieBurgersServed * repo.CostOfPackaging)));
            }
            else
            {
                Console.WriteLine("unknown item: " + item_type);
            }
        }
    }
}
