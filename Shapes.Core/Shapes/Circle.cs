using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core.Shapes
{
    public class Circle : ShapeBase
    {
        public double Radius { get; set; }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }    
    }
}
