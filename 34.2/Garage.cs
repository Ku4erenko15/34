using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34._2
{
    class Garage
    {
        public List<Lorry> lorrys = new List<Lorry>();
        public List<Car> cars = new List<Car>();
        public List<Bicycle> bicycles = new List<Bicycle>();

        public void AddLorry()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxCapacity = 0;
            
            Console.Write("Введите цену: ");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите максимальную скорость: ");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите год выпуска: ");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите грузоподьемность: ");
            try
            {
                MaxCapacity = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            lorrys.Add(new Lorry(prise, maxspeed, year, MaxCapacity));

        }
        public void AddCar()
        {
            int prise = 0, maxspeed = 0, year = 0, Power = 0, brand = 0;
            Console.WriteLine("Введите марку: ");
            try
            {
                brand = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите мощность:");
            try
            {
                Power = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            cars.Add(new Car(prise, maxspeed, year, Power));
        }
        public void AddBicycle()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxPassengers = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите количество пасажиров:");
            try
            {
                MaxPassengers = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            bicycles.Add(new Bicycle(prise, maxspeed, year, MaxPassengers));
        }
        public void GetAllLorry()
        {
            foreach (Lorry lorry in lorrys)
            {
                Console.WriteLine($"Цена: {lorry.Price}\tМаксимальная скорость: {lorry.Maxspeed}\tГод: {lorry.Year}\tМаксимальная грузоподьемность: {lorry.MaxCapacity}");
            }
        }
        /// <summary>
        /// Вывод всех элементов списка автомобилей
        /// </summary>
        public void GetAllCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"Цена: {car.Price}\tМаксимальная скорость: {car.Maxspeed}\tГод: {car.Year}\tМощность: {car.Power}");
            }
        }
        public void GetAllBicycle()
        {
            foreach (Bicycle bicycle in bicycles)
            {
                Console.WriteLine($"Цена: {bicycle.Price}\tМаксимальная скорость: {bicycle.Maxspeed}\tГод: {bicycle.Year}\tМаксимум пасажиров: {bicycle.MaxPassengers}");
            }
        }
    } 
}
