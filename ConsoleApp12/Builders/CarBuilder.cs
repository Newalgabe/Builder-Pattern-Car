using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Builders
{
    public interface CarBuilder
    {
        void BuildModel();
        void BuildColor();
        void BuildInterior();
        void BuildMonitor();
        void BuildCameras();
        void BuildSunroof();
        Products.Car GetCar();
    }
}
