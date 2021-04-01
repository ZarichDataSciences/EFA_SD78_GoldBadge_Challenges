using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBBQ
{
    class ProgramUI
    {
        FoodSalesRepo repo = new FoodSalesRepo(); //instantiate repo

        public void Run()
        {
            while (true)
            {
                Console.WriteLine(
                    "Welcome to the Company BBQ Sales Tracker!\n" +
                    "Type (1) to sell a Hamburger\n" +
                    "Type (2) to sell a VeggieBurger\n" +
                    "Type (3) to sell a Hotdog\n" +
                    "Type (4) to sell a IceCream\n" +
                    "Type (5) to sell a Popcorn\n" + 
                    "Type (6) to display total sales and revenue\n" +
                    "Type (0) to exit the program"
                );

                string userInput = Console.ReadLine();
                Console.Clear();

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
                    DisplayCostOfItemsSold("Popcorn");
                    DisplayCostOfItemsSold("Hamburger");
                    DisplayCostOfItemsSold("IceCream");
                    DisplayCostOfItemsSold("HotDog");
                    DisplayCostOfItemsSold("VeggieBurger");
                    Console.WriteLine("Press any key to continue sales.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please enter valid selection. Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        void DisplayCostOfItemsSold(string item_type) //calcs amounts sold by calling on values in the repo
        {
            if (item_type == "Popcorn")
            {
                Console.WriteLine("total popcorn sold (" + repo.NumberPopcornBagsServed + " units) is: $"
                    + ((repo.NumberPopcornBagsServed * repo.CostOfPopcorn) + (repo.NumberPopcornBagsServed * repo.CostOfPackaging)));
            } 
            else if (item_type == "Hamburger")
            {
                Console.WriteLine("total cost of hamburgers sold (" + repo.NumberHamburgersServed + " units) is: $" 
                    + ((repo.NumberHamburgersServed * repo.CostOfHamburger) + (repo.NumberHamburgersServed * repo.CostOfPackaging)));
            }
            else if (item_type == "IceCream")
            {
                Console.WriteLine("total cost of ice creams sold (" + repo.NumberIceCreamServed + " units) is: $"
                    + ((repo.NumberIceCreamServed * repo.CostOfIceCream) + (repo.NumberIceCreamServed * repo.CostOfPackaging)));
            }
            else if (item_type == "HotDog")
            {
                Console.WriteLine("total cost of hot dogs sold (" + repo.NumberHotDogsServed + " units) is: $"
                    + ((repo.NumberHotDogsServed * repo.CostOfHotDog) + (repo.NumberHotDogsServed * repo.CostOfPackaging)));
            }
            else if (item_type == "VeggieBurger")
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
