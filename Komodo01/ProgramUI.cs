using System;
using System.Collections.Generic;

namespace Komodo01
{
    public class ProgramUI
    {
        Repo _repo = new Repo(); 

        internal void Run()
        {
            while (true)
            {
                Console.WriteLine("Type (1) to see all claims \n" +
                    "Type (2) to take care of next claim \n" +
                    "Type (3) to enter a new claim \n" +
                    "Type (0) to exit the program");
                string userInput = Console.ReadLine();
                if (userInput == "0")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else if (userInput == "1")
                {
                    // #1 is see all claims
                    for(int i = 0; i < _repo.GetListOfKlaims().Count; i++)
                    {
                        Klaim curKlaim = _repo.GetListOfKlaims()[i];
                        DisplayKlaim(i, curKlaim); 
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (userInput == "2")
                {
                    // #2 take care of next claim - delete from queue if 'handled' 
                    List<Klaim> klaimsList = _repo.GetListOfKlaims(); 
                    if (klaimsList.Count == 0) // its empty
                    {
                        Console.WriteLine("there are no active claims in the repo");
                        continue; 
                    }

                    DisplayKlaim(0, klaimsList[0]);
                    Console.WriteLine("Do you want to deal with this claim now(y/n)?");
                    String handle_now = Console.ReadLine();

                    if (handle_now == "n")
                        continue;

                    klaimsList.RemoveAt(0);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("What type of claim? 1 - Kar, 2 Home, 3 - theft");
                    String userInputType = Console.ReadLine();
                    Console.WriteLine("Enter description of claim.");
                    String usingInputDesc = Console.ReadLine();
                    Console.WriteLine("Enter amount of claim.");
                    String usingInputAmt = Console.ReadLine();

                    Console.WriteLine("Enter date of accident in this format: Jan 1, 2009 ");
                    String usingInputAccident = Console.ReadLine();
                    DateTime dateOfAccident = DateTime.Parse(usingInputAccident);

                    bool isValid = true;
                    if ((DateTime.Now - dateOfAccident).TotalDays > 30)
                        isValid = false;

                    if (userInputType == "1")
                    {
                        KarKlaim kar_klaim = new KarKlaim(0, usingInputDesc, Convert.ToDouble(usingInputAmt), dateOfAccident, DateTime.Now, isValid);
                        _repo.enterANewClaim(kar_klaim); // because enterNewClaim accepts parent "Klaim" type, we can pass child
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (userInputType == "2")
                    {
                        KTheftKlaim theft_klaim = new KTheftKlaim(0, usingInputDesc, Convert.ToDouble(usingInputAmt), dateOfAccident, DateTime.Now, isValid);
                        _repo.enterANewClaim(theft_klaim); // because enterNewClaim accepts parent "Klaim" type, we can pass child
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (userInputType == "3")
                    {
                        KHomeKlaim home_claim = new KHomeKlaim(0, usingInputDesc, Convert.ToDouble(usingInputAmt), dateOfAccident, DateTime.Now, isValid);
                        _repo.enterANewClaim(home_claim); // because enterNewClaim accepts parent "Klaim" type, we can pass child
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("We didn't understand your type of claim, press any key and try again.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid selection.");
                }
            }
        }

        void DisplayKlaim(int klaim_idx, Klaim klaim)
        {
            Console.WriteLine("Klaim Info\n"
            + "----------------------------------------------\n"
            + "Claim number is: " + Convert.ToString(klaim_idx) + "\n"
            + "Claim type is: " + klaim.ClaimType + "\n"
            + "Date of incident is: " + klaim.DateOfIncident + "\n"
            + "Date of claim is: " + klaim.DateOfClaim + "\n"
            + "Claim amount is: " + klaim.ClaimAmount + "\n"
            + "Claim descriptionis: " + klaim.Description + "\n"
            + "Was claim entered within 30 days: " + klaim.IsValid + "\n"
            + "----------------------------------------------\n");
        }
    }
}