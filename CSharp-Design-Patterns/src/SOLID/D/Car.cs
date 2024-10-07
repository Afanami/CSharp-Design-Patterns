﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns.src.SOLID.D
{
    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine) {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started.");
        }
    }
}
