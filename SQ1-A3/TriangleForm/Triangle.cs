using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleForm{

    public class Triangle  {

        public double CalculateHypotenuse(double sideA, double sideB) {
            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }
    }
}
