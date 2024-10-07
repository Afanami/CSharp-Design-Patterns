using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns.src.OopsPrinciples.Polymorphism
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Starting the vehicle...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping.");
        }
    }
}
