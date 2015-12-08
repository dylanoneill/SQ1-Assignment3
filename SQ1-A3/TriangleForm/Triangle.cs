using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleForm{

    public class Triangle  {

        //Calculate hypotenuse by using the pythagorean theorem
        public double CalculateHypotenuse(double sideA, double sideB) {
            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }

        //Calculate third angle by subtracting the 2 given angles from 180
        public double CalculateThirdAngle(double angleA, double angleB) {
            return 180 - angleA - angleB;
        }

        //Calculate area by formula A * B / 2
        //public double CalculateArea(double sideA, double sideB) {
        //    return sideA * sideB / 2;
       // }
    }
}
