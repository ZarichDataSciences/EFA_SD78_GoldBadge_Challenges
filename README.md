# ElevenFiftyAcademy Gold Badge Challenges
SD78    Nathan Zarich   01APR2021
## The Following Are My Chosen Challenges

- Komodo Kompany BBQ
- Komodo Kafe
- Komodo Klaims

## Features

- Each console app is designed to take in user input via a menu system that is numbered.
- There is limited user input error detection, but where applicable exists.
- All code is written and presented in MS C# .NET 4.7.2
- Each project is organized as repos, UI and applicable classes and methods to implement connectivity.
- Each challenge has separate but similarly named Unit Test found in the same solution.

## Installation

My Console Apps Require MS Visual Studio to visualize and compile.

Please find the most recent version here:

```sh
https://visualstudio.microsoft.com/downloads/
```

## Komodo Kompany BBQ Rubric

Komodo Barbecue
Scenario:

Komodo Insurance is trying to improve their efficiency in spending for company barbecues. They have two booths: an ice cream booth and a burger booth. Each employee is given one ticket for each of the booths. Each employee can get one (meat or veggie)burger or one hotdog with the burger booth ticket. Each employee can get one ice cream cone with their ice cream ticket.

 
The app will track data about the barbecue after it is over. Here's what they want to do:

They will want to show a total cost for the party.

They also want to track total tickets taken at each booth and total tickets taken at the party.

 
For the burger booths:

they want to calculate the cost of each major type of food: veggie burgers, hamburgers, and hot dogs. (This cost will include the cost of the bun). The cost of ketchup, mustard, plasticware, and napkins can all be dumped in one miscellaneous lump sum property together.
For treat booths:

they want to calculate the cost of each bag of popcorn and each gallon of ice cream. They will also need to collect the total number of tickets taken for this booth. The cost of spoons, bowls, and miscellaneous items can be thrown into one lump sum.

 

One key result in the program will be for party planners to see a list of all parties with total cost and total tickets taken for an event.

## My Implemention for Komodo BBQ

I created one project named KomodoBBQ, and Test Unit named UnitTestBBQ
The class Program instantiates the class ProgramUI which in turn instantiates class Repo
CRUD is handled by ProgramUI
## Komodo Kafe Rubric
Komodo cafe is getting a new menu. The manager wants to be able to create new menu items, delete menu items, and receive a list of all items on the cafe's menu. She needs a console app.

 
The Menu Items:

    A meal number, so customers can say "I'll have the #5"
    A meal name
    A description
    A list of ingredients,
    A price

 
Your Task:

    Create a Menu Class with properties, constructors, and fields.
    Create a MenuRepository Class that has methods needed.
    Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
    Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.
## My Implemention for Komodo Kafe
In this scenario I broke up the application into two projects:
-KomodoKafeRepository
-KomodoKafeKonsoleApp
The Unit Tests are called
-UnitTestsKafe

Please note, there are zero initial menu items. ALL items must be manually entered upon launch.

## Komodo Klaims Rubric
Komodo has a bug in its software and needs some new code.
The Claim has the following properties:

    ClaimID
    ClaimType
    Description
    ClaimAmount
    DateOfIncident
    DateOfClaim
    IsValid

Komodo allows an insurance claim to be made up to 30 days after an incident took place. If the claim is not in the proper time limit, it is not valid.
A ClaimType could be the following:

    Car
    Home
    Theft

 
The app will need methods to do the following:
Show a claims agent a menu:
Choose a menu item:
1. See all claims
2. Take care of next claim
3. Enter a new claim

For #1, a claims agent could see all items in the queue listed out like this:
ClaimID 	Type 	Description 	Amount 	DateOfAccident 	DateOfClaim 	IsValid
1 	Car 	Car accident on 465. 	$400.00 	4/25/18 	4/27/18 	true
2 	Home 	House fire in kitchen. 	$4000.00 	4/11/18 	4/12/18 	true
3 	Theft 	Stolen pancakes. 	$4.00 	4/27/18 	6/01/18 	false

For #2, when a claims agent needs to deal with an item they see the next item in the queue.
Here are the details for the next claim to be handled:
ClaimID: 1
Type: Car
Description: Car Accident on 464.
Amount: $400.00
DateOfAccident: 4/25/18
DateOfClaim: 4/27/18
IsValid: True
Do you want to deal with this claim now(y/n)? y

When the agent presses 'y', the claim will be pulled off the top of the queue. If the agent presses 'n', it will go back to the main menu.

For #3, when a claims agent enters new data about a claim they will be prompted for questions about it:
Enter the claim id: 4
Enter the claim type: Car
Enter a claim description: Wreck on I-70.
Amount of Damage: $2000.00
Date Of Accident: 4/27/18
Date of Claim: 4/28/18
This claim is valid.
  
## My Implemention for Komodo Klaims.
Klaims is coded differently than the other challenges due to the need for sub claim catagories.
To accomplish there is a directory in the project titled 'KlaimsKlasses' that contains a parent class Klaim.cs
and three child classes KarKlaim.cs, KHomeKlaim.cs and KTheftKlaim.cs. The program relies on a very basic form of
polymorphism to pass data between the repo and the klaims klasses. 

Please note, there are NO initial claims. Claims MUST be manually entered to view.