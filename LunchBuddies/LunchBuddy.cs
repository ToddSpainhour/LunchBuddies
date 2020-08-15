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
        }




        // methods

        public virtual void Eat()
        {
            Console.WriteLine($"\"{FirstName} {LastName} and I decided to catch up during lunch.\"");
        }



        //////////
        


        public virtual void Eat(string food)
        {
            Console.WriteLine($"\"{FirstName} and I decided to get {food} for lunch.\"");
        }






        public void Eat(List<LunchBuddy> lunchCompanions) // why List<LunchBuddy> companions and not List<LunchBuddies> companions?
        {

            var restaurant = new Restaurant();

            List<string> theOthersInTheGroup = new List<string>();

            //List<string> commaSeperatedListOfOthersInTheGroup = new List<string>();

            string everybodyElse = string.Empty;



            foreach (var companion in lunchCompanions)
            {
                var otherNames = companion.FirstName;

                if (otherNames == FirstName)
                {
                    Console.WriteLine("");
                }
                else
                {
                    theOthersInTheGroup.Add(companion.FirstName);
                }


                everybodyElse = string.Join(" and ", theOthersInTheGroup);
            }


            Console.WriteLine($"{FirstName} will meet me at {restaurant.Name} along with {everybodyElse}.");

        }



        //public virtual void Eat(string food, List<LunchBuddy> companions)
        public virtual void Eat(string food, List<LunchBuddy> companions)
        {

            var restaurant = new Restaurant();
            List<string> othersInTheGroup = new List<string>();
            string everybodyElse = string.Empty;

            foreach (var companion in companions)
            {
                var otherNames = companion.FirstName;

                if (otherNames == FirstName)
                {
                    Console.WriteLine("");
                }
                else
                {
                    othersInTheGroup.Add(otherNames);
                }

                everybodyElse = string.Join(" and ", othersInTheGroup);

            }

            Console.WriteLine($"I met up {FirstName}, along with {everybodyElse}, to get some {food} from {restaurant.Name}.");
        }





}
}
