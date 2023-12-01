using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Builders
{
    public class LuxuryCarBuilder : CarBuilder
    {
        private Products.Car car = new Products.Car();

        public void BuildModel()
        {
            car.Model = "Luxury Car";
        }

        public void BuildColor()
        {
            car.Color = "Elegant color";
        }

        public void BuildInterior()
        {
            car.Interior = "Luxury Interior";
        }

        public void BuildMonitor()
        {
            car.Monitor = "High-end Monitor";
        }

        public void BuildCameras()
        {
            car.Cameras = "Advanced Cameras";
        }

        public void BuildSunroof()
        {
            car.Sunroof = "Panoramic sunroof";
        }

        public Products.Car GetCar()
        {
            return car;
        }
    }
}
