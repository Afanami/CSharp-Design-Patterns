using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns.src.OopsPrinciples.Inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Starting the vehicle...");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping.");
        }
    }
}
