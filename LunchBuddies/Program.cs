using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {



        static void Main(string[] args)
        {



            var restaurantOne = new Restaurant();



            // Console.WriteLine($"The first randomly selected restaurant is {restaurantOne.Name}");


            ///////

            var lunchBuddyOne = new LunchBuddy("Scout", "Spainhour");
            var lunchBuddyTwo = new LunchBuddy("Jimbo", "McLean");
            var lunchBuddyThree = new LunchBuddy("Cindy", "Bender");


            var lunchCompanions = new List<string>();

            lunchCompanions.Add($"{lunchBuddyOne.FirstName} {lunchBuddyOne.LastName}");
            lunchCompanions.Add($"{lunchBuddyTwo.FirstName} {lunchBuddyTwo.LastName}");
            lunchCompanions.Add($"{lunchBuddyThree.FirstName} {lunchBuddyThree.LastName}");


            Console.WriteLine($"lunchCompanions returns {lunchCompanions}");

           

            Console.WriteLine(@"lunchBuddyOne.Eat()");
            Console.WriteLine(@"{FirstName} {LastName} and I decided to catch up during lunch. and returns...");
            lunchBuddyOne.Eat();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\b");

            
            

            Console.WriteLine("lunchBuddyOne.Eat(string food)");
            Console.WriteLine(@"{FirstName} and I decided to get {food} for lunch.");
            lunchBuddyOne.Eat("Pizza");
            Console.WriteLine(new string('-', 50));


            

            // eat(List<LunchBuddy> companions) - Will select a random restaurant name from a list of strings, 
            // print to console that the buddy is at that restaurant,
            // and also output the first name of each lunch buddy in the specified list.

            Console.WriteLine(@"lunchBuddyOne.Eat()");  // ask for clarification
            //Console.WriteLine(@"{FirstName} and I decided to go to {} for lunch.");
            lunchBuddyOne.Eat();
            Console.WriteLine(new string('-', 50));











            //var restaurantTwo = new Restaurant();

            //var lunchBuddyTwo = new LunchBuddy("Jimbo", "McLean");

            //lunchBuddyTwo.Eat("burgers");

            ////var lunchItemTwo = new LunchBuddy.Eat("Burgers");

            ////Eat("Burgers");

            //Console.WriteLine($"My lunch plans on Tuesday are with {lunchBuddyTwo.FirstName} {lunchBuddyTwo.LastName} and we might go to {restaurantTwo.Name} to eat {lunchBuddyTwo.Eat()}.");

            Console.ReadKey();

        }
    }
}
