using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static List<Car> listOfCars = new List<Car>()
        {
            new Car(1, "Ford", "Y", Color.Red, 20000, new DateTime(1990, 12, 22)),
            new Car(2, "Porsche", "718 Spyder", Color.Green, 55555, new DateTime(1995, 9, 10)),
            new Car(3, "Tesla", "S", Color.Red, 1044000, new DateTime(2004, 7, 7)),
            new Car(4, "Tesla", "E", Color.Blue, 230000, new DateTime(1999, 7, 4))
        };

        static void Main(string[] args)
        {
            listOfCars
                .Where(car => car.Color == Color.Red)
                .ToList()
                .ForEach(car => Console.WriteLine($"Price of a red {car.BrandName} model: '{car.ModelName}' car {car.CalculatePrice()}"));

            listOfCars
                .Where(car => car.BrandName.ToLower() == "ford")
                .ToList()
                .ForEach(car => Console.WriteLine($"Price of a ford {car.ModelName} brand name {car.CalculatePrice()}"));

            listOfCars
                .Where(car => car.DistanceTraveled < 100000)
                .ToList()
                .ForEach(car => Console.WriteLine
                            (
                                $"Car with KM less then 100,000 \n " +
                                $"Id: {car.Id}, BrandName: {car.BrandName}, Model: {car.ModelName}, Color: {car.Color}, Distance Traveled: {car.DistanceTraveled}, Year of Car: {car.DateOfModel.Year}"
                            )
                        );
        }
    }
}
