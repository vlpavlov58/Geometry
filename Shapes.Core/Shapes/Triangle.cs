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
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }

        public override double GetPerimetr()
        {
            return Side_A + Side_B + Side_C;
        }

        public override double GetArea()
        {
            return 0.5 * Side_A * Height;
        }
    }
}
