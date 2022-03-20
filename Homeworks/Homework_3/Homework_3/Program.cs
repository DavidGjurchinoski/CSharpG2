using Homework_3.Entities;
using System;
using System.Collections.Generic;

namespace Homework_3
{
    class Program
    {
            private static Driver[] driversArray = {
            new Driver("Bob", 1),
            new Driver("Greg", 2),
            new Driver("Jill", 3),
            new Driver("Anne", 4)
            };

            private static Car[] carsArray = {
            new Car("Hyundai", 10, null),
            new Car("Mazda", 20, null),
            new Car("Ferrari", 30, null),
            new Car("Porsche", 40, null)
            };

            private static Driver firstDriver;
            private static Driver secondDriver;

            private static Car firstCar;
            private static Car secondCar;

        static void Main(string[] args)
        {
            string raceAgain;
            do
            {
                //Reseting the values
                firstDriver = new Driver("", 0);
                secondDriver = new Driver("", 0);
                firstCar = new Car("", 0, null);
                secondCar = new Car("", 0, null);
                
                RaceAgain();

                Console.WriteLine("Enter 'yes' to race again");
                raceAgain = Console.ReadLine();
            } while (raceAgain.ToLower() == "yes");
        }

        static void RaceCars(Car carOne, Car carTwo)
        {
            int carOneSpeed = carOne.CalculateSpeed(carOne.Driver);
            int carTwoSpeed = carTwo.CalculateSpeed(carTwo.Driver);

            if (carOneSpeed != carTwoSpeed)
            {
                Car winnerCar = carOneSpeed > carTwoSpeed ? carOne : carTwo;

                Console.WriteLine($"The driver {winnerCar.Driver.Name} driving the model {winnerCar.Model} at a speed of {winnerCar.CalculateSpeed(winnerCar.Driver)} WON the Race!");
            }
        }

        static void printCarsList()
        {
            Console.WriteLine("Enter the model of the car you want to choose(from the list):");

            foreach (Car car in carsArray)
            {
                if(firstCar.Model != car.Model) Console.WriteLine(car.Model);
            }
        }

        static void printDriversList()
        {
            Console.WriteLine("Enter the name of the driver you want to choose(from the list):");

            foreach (Driver driver in driversArray)
            {
                if (firstDriver.Name != driver.Name)
                {
                    Console.WriteLine(driver.Name); 
                }
            }
        }

        static Driver findDriverByName(string name)
        {
            foreach (Driver driver in driversArray)
            {
                //Searching for the right driver and that the second driver is diffrent from the first
                if(driver.Name.ToLower() == name.ToLower() && firstDriver.Name != name)
                {
                    Console.WriteLine($"You have chosen the driver: {driver.Name}");
                    Console.WriteLine();

                    return driver;
                }
            }
            Console.WriteLine($"The name {name} does not match any of the available DRIVERS!");
            Console.WriteLine();

            return new Driver("", 0); 
        }

        static Car findCarByModel(string model)
        {
            foreach(Car car in carsArray)
            {
                //Searching for the right car and that the second car is diffrent from the first
                if (car.Model.ToLower() == model.ToLower() && firstCar.Model != model)
                {
                    Console.WriteLine($"You have chosen the model: {car.Model}.");
                    Console.WriteLine();

                    return car;
                }
            }

            Console.WriteLine($"The model {model} does not match any of the available CARS!");
            Console.WriteLine();
            
            return new Car("", 0, null);
        }

        static void RaceAgain()
        {
            printDriversList();
            firstDriver = findDriverByName(Console.ReadLine());

            printCarsList();
            firstCar = findCarByModel(Console.ReadLine());

            printDriversList();
            secondDriver = findDriverByName(Console.ReadLine());

            printCarsList();
            secondCar = findCarByModel(Console.ReadLine());

            if (
                firstDriver.Name != "" &&
                firstCar.Model != "" &&
                secondDriver.Name != "" &&
                secondCar.Model != ""
                )
            {
                RaceCars(
                    new Car(firstCar.Model, firstCar.Speed, new Driver(firstDriver.Name, firstDriver.Skill)),
                    new Car(secondCar.Model, secondCar.Speed, new Driver(secondDriver.Name, secondDriver.Skill))
                    );
            }
            else
            {
                Console.WriteLine("Invalid Inputs! Try Again!");
            }
        }
    }
}
