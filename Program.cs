using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task1
{
    class Program
    {
        static void Main()
        {
            Square s1 = new Square(12);
            Square s2 = new Square(4);
            Square s3 = new Square(6);
            Square s4 = new Square(2);

            Square[] squares = new Square[] { s1, s2, s3, s4 };

            Array.Sort(squares, new PerimeterCompare());
            Console.WriteLine("Squares sorted by perimeter");

            foreach (Square item in squares)
                Console.WriteLine("{0}", item.GetPerimeter);

            Console.ReadKey();
        }
    }
}
