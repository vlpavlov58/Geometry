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
            var rectPerimetr = rect.GetPerimetr();
            var rectArea = rect.GetArea();
            Console.WriteLine($"Rectangle Area: {rectArea} \n" +
                $"Recatngle Perimetr: {rectPerimetr}");
            Console.WriteLine();


            Rectangle rect2 = new Square(2, 2);
            var squarePerimetr = rect2.GetPerimetr();
            var squareArea = rect2.GetArea();
            Console.WriteLine($"Square Area: {squareArea} \n" +
                $"Square Perimetr: {squarePerimetr}");
            Console.WriteLine();

            Circle circle = new Circle();
            circle.Radius = 5.63;
            var circlePerimetr = circle.GetPerimetr();
            var circleArea = circle.GetArea();
            Console.WriteLine($"Circle Area: {circleArea} \n" +
                $"Circle Perimetr: {circlePerimetr}");
            Console.WriteLine();

            Ellipse ellipse = new Ellipse(12.1, 17.8);
            var ellipsePerimetr = ellipse.GetPerimetr();
            var ellipseArea = ellipse.GetArea();
            Console.WriteLine($"Ellipse Area: {ellipseArea} \n" +
                $"Ellipse Perimetr: {ellipsePerimetr}");
            Console.WriteLine();

            Triangle triangle = new Triangle();
            triangle.Height = 14;
            triangle.Side_A = 78;
            triangle.Side_B = 45;
            triangle.Side_C = 45;
            var trianglePerimetr = triangle.GetPerimetr();
            var triangleArea = triangle.GetArea();
            Console.WriteLine($"Triangle Area: {triangleArea} \n" +
                $"Triangle Perimetr: {trianglePerimetr}");
            Console.WriteLine();

            Triangle rightTriangle = new RightTriangle(14, 15, 20.5);
            var rightTrianglePerimetr = rightTriangle.GetPerimetr();
            var rightTriangleArea = rightTriangle.GetArea();
            Console.WriteLine($"Right Triangle Area: {rightTriangleArea} \n" +
                $"Right Triangle Perimetr: {rightTrianglePerimetr}");
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
