using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");
            List<Restaurant> restaurants = new List<Restaurant>
{
    new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
    new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
    new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
    new Restaurant(4, "dior", "perfume", 4.9),
    new Restaurant(5, "delina", "perfume", 4.7),

};
foreach (var item in restaurants)
{ 

    Console.WriteLine($"{item.ID}. {item.Name} ({item.Type}) - Rating: {item.Rating}");
}
            var amount = restaurants.Count();
            var avg = restaurants.Aggregate(x => x.rating);
            Console.WriteLine($"Total is {amount}");
            Console.WriteLine($"Score Average is {avg}");

        }
    }
    class Restaurant
    {
        public int ID { get; set;}
        public string Name { get; set;}
        public string Type { get; set;}
        public double Rating { get; set;}

        public Restaurant (int id, string name, string type, double rating)
        { 
            ID = id;
            Name = name;
            Type = type;
            Rating = rating;
        }

    }
}
