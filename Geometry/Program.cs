using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Core;
using Shapes.Core.Shapes;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5,10);
            var s = rect.GetPerimetr();
            var e = rect.GetSquare();
            Rectangle rect2 = new Square(2, 2);
            var d = rect2.GetSquare();

            Console.WriteLine($"{d}, {e}");
            Console.ReadLine();
        }
    }
}
