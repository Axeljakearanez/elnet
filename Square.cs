using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square : Shape
    {
        private double sideLength;

        public Square() { }

        public Square(string name, string color, int noSide, double sideLength)
        {
            base.Name = name;
            base.Color = color;
            base.NoSide = noSide;
            this.SideLength = sideLength;
        }

        public double SideLength { get => sideLength; set => sideLength = value; }

        public override string ToString()
        {
            return "\nName: " + base.Name +
                "\nColor: " + base.Color +
                "\nNo. of Sides: " + base.NoSide +
                "\nLength of one side: " + this.SideLength +
                "\nArea of the Square:" + this.ComputeArea(); ;

        }
        public override double ComputeArea()
        {
            return Math.Pow(this.SideLength, 2);
        }
    }
}

