using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core.Shapes
{
    public class Triangle : ShapeBase
    {
        public double Height { get; set; }
        public double Footing { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Triangle (double height, double footing, double side1, double side2)
        {
            this.Height = height;
            this.Footing = footing;
            this.Side1 = side1;
            this.Side2 = side2;
        }


        public override double GetPerimetr()
        {
            return Footing + Side1 + Side2;
        }

        public override double GetSquare()
        {
            return 0.5 * Footing * Height;
        }
    }
}
