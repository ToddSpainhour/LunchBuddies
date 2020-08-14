using System;
using System.Collections.Generic;
using System.Text;
using LunchBuddies;

namespace LunchBuddies
{
    class LunchBuddy
    {

        // properties

        public string FirstName { get; set; }
        public string LastName { get; set; }


        // constructor

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("\b");
        }




        // methods

        public virtual void Eat()
        {
            Console.WriteLine($"\"{FirstName} {LastName} and I decided to catch up during lunch.\"");
        }





        public virtual void Eat(string food)
        {
            Console.WriteLine($"\"{FirstName} and I decided to get {food} for lunch.\"");
        }





        public void Eat(List<LunchBuddy> companions) // why List<LunchBuddy> companions and not List<LunchBuddies> companions?
        {

            var restaurant = new Restaurant();

            Console.WriteLine($"{companions} is waiting at {restaurant}");

            foreach (var companion in companions)
            {
                Console.WriteLine($"This companion is {companion}");
            }
        }





        public virtual void Eat(string food, List<LunchBuddy> companions)
        {
            Console.WriteLine("-- inside your Eat(string food, List<LunchBuddy> companions) method --");
            Console.WriteLine($"Your food argument was {food}, and your companions argument was {companions}");
        }





    }
}
