using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public Rectangle(string name, string color, int noSide, double length, double width)
        {
            base.Name = name;
            base.Color = color;
            base.NoSide = noSide;
            this.Length = length;
            this.Width = width;
        }

        public override string ToString()
        {
            return "\nName: " + this.Name +
                   "\nColor: " + this.Color +
                   "\nNo of Side: " + this.NoSide +
                   "\nLength of Rectangle: " + this.Length +
                   "\nWidth of Rectangle: " + this.Width +
                   "\nArea of a Shape: " + ComputeArea();
        }

        public override double ComputeArea()
        {
            return this.Length * this.Width; 
        }
    }
}
