using System;
using System.Collections.Generic;
using ObjectsPlay.Objects;
using ObjectsPlay.Data;

namespace ObjectsPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the list of persons
            PersonData pData = new PersonData();
            Person[] persons = pData.GetPersons();
            //write the story of each person
            for(int i = 0; i < persons.Length; i++)
            {
                Person temp = persons[i];
                Console.WriteLine("My name is " + temp.FirstName + " " + temp.LastName);
            }










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
