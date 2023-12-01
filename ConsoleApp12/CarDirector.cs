using ConsoleApp12.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Directors
{
    public class CarDirector
    {
        public Products.Car Construct(CarBuilder builder)
        {
            builder.BuildModel();
            builder.BuildColor();
            builder.BuildInterior();
            builder.BuildMonitor();
            builder.BuildCameras();
            builder.BuildSunroof();

            return builder.GetCar();
        }
    }
}