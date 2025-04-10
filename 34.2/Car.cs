using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34._2
{
     class Car:Vehicle
    {
        private string brand;
        private int power;
        
        public int Power { get => power; set => power = value; }
        public string Brand { get => brand; set => brand = value; }

      

        public Car(int price, int maxspeed, int year, int power) : base(price, maxspeed, year)
        {
            Power = power;
            Brand = brand;
        }

        public override void Info()
        {
        Console.WriteLine($"Car - Price: ${Price}, Max Speed: {Maxspeed} km/h, Year: {Year}, Horsepower: {Power} hp");
        }

    }
}
