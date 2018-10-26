using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core.Shapes
{
    public class Ellipse : ShapeBase
    {
        public double Semiaxis1 { get; set; }
        public double Semiaxis2 { get; set; }

        public Ellipse(double semiaxis1, double semiaxis2)
        {
            this.Semiaxis1 = semiaxis1;
            this.Semiaxis2 = semiaxis2;
        }

        public override double GetPerimetr()
        {
            return Math.PI * (this.Semiaxis1 + this.Semiaxis2);
        }

        public override double GetSquare()
        {
            return Math.PI * Semiaxis1 * Semiaxis2;
        }
    }
}
