using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        // properties 
        private List<string> RestaurantNames { get; set; }
        public string Name { get; set; }

        // constructor 
        public Restaurant()
        {
            var restaurantNames = new List<string> { "Dalton's", "Ty's", "Rhinehart's" };
            
            Random randomRestaurant = new Random();

            int randomlyPickedRestaurant = randomRestaurant.Next(restaurantNames.Count);

            Name = restaurantNames[randomlyPickedRestaurant];


        }

    }
}
