using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3.Entities
{
    class Car
    {
        public string Model;

        public int Speed;

        public Driver Driver;

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            //is it better to set the driver as a reference or to make a new instance of the same object?
            Driver = driver;
            //Driver = new Driver(driver.Name, driver.Skill);
        }

        public int CalculateSpeed(Driver driver)
        {
            return driver.Skill * Speed;
        }
    }
}
