using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core.Shapes
{
    public class Rectangle : ShapeBase
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle (double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetPerimetr()
        {
            return 2*Width+2*Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
