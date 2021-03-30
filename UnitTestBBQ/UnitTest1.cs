using KomodoBBQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBBQ
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // instantiate BBQ repo
            FoodSalesRepo repo = new FoodSalesRepo();

            /*public int NumberHamburgersServed { get; set; }
         public int NumberHotDogsServed { get; set; }
         public int NumberVeggieBurgersServed { get; set; }
         public int NumberIceCreamServed { get; set; }
         public int NumberPopcornBagsServed { get; set; }
            */

            // add stuff to repo
            repo.NumberHamburgersServed++;
            repo.NumberHotDogsServed++;
            repo.NumberVeggieBurgersServed++;
            repo.NumberIceCreamServed++;
            repo.NumberPopcornBagsServed++;

            // TEST - make sure what you expected is now in the repo

            //Assert.AreEqual(repo.ReturnListKafeMenuItems()[0].MealName, "test item 1 name");
            Assert.AreEqual(repo.NumberHamburgersServed, 1);
            Assert.AreEqual(repo.NumberHotDogsServed, 1);
            Assert.AreEqual(repo.NumberVeggieBurgersServed, 1);
            Assert.AreEqual(repo.NumberIceCreamServed, 1);
            Assert.AreEqual(repo.NumberPopcornBagsServed, 1);

        }
    }
}
