using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {



        static void Main(string[] args)
        {



            var restaurantOne = new Restaurant();





            
            ///// had these as var

            LunchBuddy lunchBuddyOne = new LunchBuddy("Scout", "Spainhour");
            LunchBuddy lunchBuddyTwo = new LunchBuddy("Jimbo", "McLean");
            LunchBuddy lunchBuddyThree = new LunchBuddy("Cindy", "Bender");


            List <LunchBuddy> lunchCompanions = new List<LunchBuddy>();

            lunchCompanions.Add(lunchBuddyOne);
            lunchCompanions.Add(lunchBuddyTwo);
            lunchCompanions.Add(lunchBuddyThree);



            // 1
            Console.WriteLine(@"lunchBuddyOne.Eat()");
            lunchBuddyTwo.Eat();




            Console.WriteLine(new string('-', 50));



            // 2
            Console.WriteLine("lunchBuddyOne.Eat(string food)");
            lunchBuddyOne.Eat("Pizza");




            Console.WriteLine(new string('-', 50));



            // 3
            Console.WriteLine(@"lunchBuddyOne.Eat(companions)"); 
            lunchBuddyThree.Eat(lunchCompanions);




            Console.WriteLine(new string('-', 50));




            // 4
            Console.WriteLine(@"lunchBuddyOne.Eat(string food, List<LunchBuddy> companions)");
            lunchBuddyThree.Eat("burgers", lunchCompanions);




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
