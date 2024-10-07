using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns.src.SOLID.D
{
    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }
}
