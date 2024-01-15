using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.Print();
            Point p2 = new Point(2, -3);
            p2.Print();
            WriteLine($"\nКоличество точек: {Point.count}");

            ReadKey();
        }
    }
}
