using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle : Shape
    {
        private double raduis;

        public double Raduis { get => raduis; set => raduis = value; }

        public Circle(string name, string color, int noSide, double raduis)
        {
            base.Name = name;
            base.Color = color;
            base.NoSide = noSide;
            this.Raduis = raduis;
        }

        public override string ToString()
        {
            return "\nName: " + base.Name +
                "\nColor: " + base.Color +
                "\n No of Side: " + base.NoSide +
                "\nRaduis of Circle " + this.Raduis +
                "\nArea of a Shape: " + ComputeArea();
        }
        public override double ComputeArea()
        {
            return Math.PI * Math.Pow(this.Raduis, 2);
        }

    }
}


