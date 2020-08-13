using System;
using System.Collections.Generic;
using System.Text;

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
            // Console.WriteLine($"As expected, {firstName} {lastName} asked to join you for lunch. (Inside your LunchBuddy constructor)");
        }




        // methods

        public virtual void Eat()
        {
            Console.WriteLine("-- inside your eat() method --");
            Console.WriteLine($"{FirstName} {LastName} decided to go out to eat. (inside your Eat() method.");
        }


        public virtual void Eat(string food)
        {
            Console.WriteLine("-- inside your eat(string food) method --");
            Console.WriteLine($"your food argument was {food}");
        }


        public virtual void Eat(List<LunchBuddy> companions)
        {
            Console.WriteLine("-- inside your Eat(List<LunchBuddy> companions) method --");
            Console.WriteLine($"your companions argument was {companions}");
        }


        public virtual void Eat(string food, List<LunchBuddy> companions)
        {
            Console.WriteLine("-- inside your Eat(string food, List<LunchBuddy> companions) method --");
            Console.WriteLine($"Your food argument was {food}, and your companions argument was {companions}");
        }
    }
}
