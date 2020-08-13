using System;
using System.Runtime.InteropServices.ComTypes;
using LunchBuddies;
using Microsoft.VisualBasic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {

            var restaurantOne = new Restaurant();

            var lunchBuddyOne = new LunchBuddy("Scout", "Spainhour");

            //Console.WriteLine($"My lunch plans on Monday are with {lunchBuddyOne.FirstName} {lunchBuddyOne.LastName} and we might go to {restaurantOne.Name}.");


            lunchBuddyOne.Eat();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\b");


            lunchBuddyOne.Eat("Pizza");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\b");







            //var restaurantTwo = new Restaurant();

            //var lunchBuddyTwo = new LunchBuddy("Jimbo", "McLean");

            //lunchBuddyTwo.Eat("burgers");

            ////var lunchItemTwo = new LunchBuddy.Eat("Burgers");

            ////Eat("Burgers");

            //Console.WriteLine($"My lunch plans on Tuesday are with {lunchBuddyTwo.FirstName} {lunchBuddyTwo.LastName} and we might go to {restaurantTwo.Name} to eat {lunchBuddyTwo.Eat()}.");



        }
    }
}
