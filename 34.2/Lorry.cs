using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34._2
{
     class Lorry:Vehicle
    {
        private int maxCapacity;

        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }

        public Lorry(int price, int maxSpeed, int year, int maxCapacity)
    : base(price, maxSpeed, year)
        {
            maxCapacity = MaxCapacity;
        }

        public override void Info()
        {
            Console.WriteLine($"Bicycle - Price: ${Price}, Max Speed: {Maxspeed} km/h, Year: {Year}, Passengers: {MaxCapacity}");
        }

    }
}
