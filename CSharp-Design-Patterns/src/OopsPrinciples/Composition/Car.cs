﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns.src.OopsPrinciples.Composition
{
    public class Car
    {
        private Engine engine = new Engine();
        private Wheels wheels = new Wheels();
        private Chassis chassis = new Chassis();
        private Seats seats = new Seats();

        public void StartCar()
        {
            engine.Start();
            wheels.Rotate();
            chassis.Support();
            seats.Sit();
            Console.WriteLine("Car started.");
        }
    }
}
