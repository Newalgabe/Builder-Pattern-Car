using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Builders
{
    public class SportsCarBuilder : CarBuilder
    {
        private Products.Car car = new Products.Car();

        public void BuildModel()
        {
            car.Model = "Sports Car";
        }

        public void BuildColor()
        {
            car.Color = "Sporty color";
        }

        public void BuildInterior()
        {
            car.Interior = "Sports Interior";
        }

        public void BuildMonitor()
        {
            car.Monitor = "Advanced Monitor";
        }

        public void BuildCameras()
        {
            car.Cameras = "Rearview cameras";
        }

        public void BuildSunroof()
        {
            car.Sunroof = "No sunroof";
        }

        public Products.Car GetCar()
        {
            return car;
        }
    }
}