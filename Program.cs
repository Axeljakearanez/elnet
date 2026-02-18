using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh;

            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Circle");
            Console.Write("ENTER CHOICE: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                sh = new Square();
                Console.Write("ENTER NAME: ");
                sh.Name = Console.ReadLine();
                Console.Write("ENTER COLOR: ");
                sh.Color = Console.ReadLine();
                Console.Write("ENTER NO. OF SIDES: ");
                sh.NoSide = int.Parse(Console.ReadLine());
                Console.Write("ENTER SIDE LENGTH: ");
                ((Square)sh).SideLength = double.Parse(Console.ReadLine()); // Correct assignment
                Console.WriteLine(sh);
            }
            else if (choice == 2)
            {
                sh = new Rectangle("", "", 4, 0, 0);
                Console.Write("ENTER NAME: ");
                sh.Name = Console.ReadLine();
                Console.Write("ENTER COLOR: ");
                sh.Color = Console.ReadLine();
                Console.Write("ENTER NO. OF SIDES: ");
                sh.NoSide = int.Parse(Console.ReadLine());
                Console.Write("ENTER LENGTH: ");
                ((Rectangle)sh).Length = double.Parse(Console.ReadLine());
                Console.Write("ENTER WIDTH: ");
                ((Rectangle)sh).Width = double.Parse(Console.ReadLine());
                Console.WriteLine(sh);
            }
            else if (choice == 3)
            {
                sh = new Circle("", "", 0, 0);
                Console.Write("ENTER NAME: ");
                sh.Name = Console.ReadLine();
                Console.Write("ENTER COLOR: ");
                sh.Color = Console.ReadLine();
                Console.Write("ENTER NO. OF SIDES: ");
                sh.NoSide = int.Parse(Console.ReadLine());
                Console.Write("ENTER RADIUS: ");
                ((Circle)sh).Raduis = double.Parse(Console.ReadLine());
                Console.WriteLine(sh);
            }

            Console.ReadLine();
        }
    }
}
