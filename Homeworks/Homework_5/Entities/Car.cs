using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Car
    {
        public Car(int id, string brandName, string modelName, Color color, long distanceTraveled, DateTime dateOfModel)
        {
            Id = id;
            BrandName = brandName;
            ModelName = modelName;
            Color = color;
            DistanceTraveled = distanceTraveled;
            DateOfModel = dateOfModel;
        }

        public int Id { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public Color Color { get; set; }

        public long DistanceTraveled { get; set; }

        public DateTime DateOfModel { get; set; }

        public long CalculatePrice()
        {
            return DistanceTraveled * DateOfModel.Year / 3;
        }
    }
}
