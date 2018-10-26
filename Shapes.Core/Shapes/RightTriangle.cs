using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Core.Shapes
{
    public class RightTriangle : Triangle
    {
        public RightTriangle (double cathetus, double cathetus2, double hypotenuse)
        {
            this.Height = Side_A = cathetus;
            this.Side_B = cathetus2;
            this.Side_C = hypotenuse;
        }
    }
}
