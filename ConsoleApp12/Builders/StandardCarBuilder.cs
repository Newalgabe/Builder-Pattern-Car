using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Builders
{
    public class StandardCarBuilder : CarBuilder
    {
        private Products.Car car = new Products.Car();

        public void BuildModel()
        {
            car.Model = "Standard Car";
        }

        public void BuildColor()
        {
            car.Color = "Any color";
        }

        public void BuildInterior()
        {
            car.Interior = "Standard Interior";
        }

        public void BuildMonitor()
        {
            car.Monitor = "Basic Monitor";
        }

        public void BuildCameras()
        {
            car.Cameras = "No cameras";
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