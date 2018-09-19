using System;
using System.Collections.Generic;
using ObjectsPlay.Objects;

namespace ObjectsPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the first car
            Car car1 = new Car();
            car1.Color = "red";
            car1.NumberOfDoors = 5;
            car1.Brand = "Toyota";
            car1.YearOfFabrication = 2017;
            car1.Price = 250000;
            car1.IsUsed = true;

            Car car2 = new Car();
            car2.Color = "blue";
            car2.NumberOfDoors = 3;
            car2.Brand = "BMW";
            car2.YearOfFabrication = 2000;
            car2.Price = 1000000;
            car2.IsUsed = true;

            Car car3 = new Car {
                Brand = "Opel",
                Color = "red",
                YearOfFabrication = 1991,
                IsUsed = true,
                NumberOfDoors = 3,
                Price = 1000
            };

            Console.WriteLine("Cars for sale:");
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());

            Console.ReadLine();
        }
    }
}
