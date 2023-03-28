using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0328b
{
    class Car
    {
        private string color = "Red";
        private string model = "Focus";
        private int maxSpeed = 180;

        public Car(string c)
        {
            color = c;
        }
        public Car(string c, string m)
        {
            color = c;
            model = m;
        }

        public Car(string c, string m, int s)
        {
            color = c;
            model = m;
            maxSpeed = s;
        }

        public void Info()
        {
            Console.WriteLine($"My Model:{model}");
            Console.WriteLine($"My Color:{color}");
            Console.WriteLine($"My MaxSpeed:{maxSpeed}");
        }

        public void ChangeColor(string newColor)
        {
            color = newColor;
        }
    }
}
