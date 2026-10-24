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
        }
    }
    class RestaurantApp
    {
        public int ID { get; set;}
        public string Name { get; set;}
        public string Type { get; set;}
        public double Rating { get; set;}

        public RestaurantApp (int id, string name, string type, double rating)
        { 
            ID = id;
            Name = name;
            Type = type;
            Rating = rating;
        } 

    }
}
