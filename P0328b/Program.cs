using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0328b
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Car Ford = new Car("White", "Focus", 180);
            Car Lexus = new Car("Red", "IS300", 250);
            Ford.Info();
            Lexus.Info();
            Lexus.ChangeColor("Golden");
            Lexus.Info();
            Console.ReadLine();
        }
    }
}
