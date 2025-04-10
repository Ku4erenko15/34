using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34._2
{
    class Bicycle:Vehicle
    {

        private int maxPassengers;

        public int MaxPassengers { get => maxPassengers; set => maxPassengers = value; }

        public Bicycle(int price, int maxSpeed, int year, int passengers)
       : base(price, maxSpeed, year)
        {
            maxPassengers = MaxPassengers;
        }

        public override void Info()
        {
            Console.WriteLine($"Bicycle - Price: ${Price}, Max Speed: {Maxspeed} km/h, Year: {Year}, Passengers: {MaxPassengers}");
        }




    }
}
