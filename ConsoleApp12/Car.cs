using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Products
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Interior { get; set; }
        public string Monitor { get; set; }
        public string Cameras { get; set; }
        public string Sunroof { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Color: {Color}, Interior: {Interior}, Monitor: {Monitor}, Cameras: {Cameras}, Sunroof: {Sunroof}");
        }
    }
}