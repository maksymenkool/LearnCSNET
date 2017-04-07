using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(100, 100, "Jane");
            Point p2 = (Point)p1.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p1: {0}", p1);
            Console.WriteLine("p2: {0}", p2);
            p2.desc.PetName = "My new Point";
            p2.X = 9;
            Console.WriteLine("After modification:");
            Console.WriteLine("p1: {0}", p1);
            Console.WriteLine("p2: {0}", p2);
        }
    }
}
