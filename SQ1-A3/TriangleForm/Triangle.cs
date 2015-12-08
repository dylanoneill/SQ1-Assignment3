/*
 * Project: SQ-I Assignment 3
 * File: Triangle.cs
 * Programmer: Dylan O'Neill
 * Date: 2015-12-05
 * Description: The methods in this file are used to perform calculations and return information
 *              about a Triangle.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleForm{

    public class Triangle  {

       /*
        * Method: CalculateHypotenuse
        * Description: Used to calculate the hypotenuse of right triangle given sides A and B
        * Returns: double - result of calculation
        *          double - zero if triangle is not a right triangle
       */
        public double CalculateHypotenuse(double sideA, double sideB, double angleC) {
            if (angleC == 90) {
                return Math.Sqrt(sideA * sideA + sideB * sideB);
            }else {
                //not right triangle
                return 0;
            }
        }

        /*
         * Method: CalculateThirdAngle
         * Description: Used to calculate the missing angle of a triangle given 2 other angles whos 
         *              sum is less than 180
         * Returns: double - result of calculation
         *          double - zero if angles sum is more than or equal to 180
        */
        public double CalculateThirdAngle(double angleA, double angleB) {
            if (angleA + angleB < 180) {
                return 180 - angleA - angleB;
            }
            else {
                //angles add up to more than 180
                return 0; 
            }
        }

       /*
        * Method: CalculateArea
        * Description: Used to calculate the area of a right triangle given sides A and B.
        * Returns: double - result of calculation
       */
        public double CalculateArea(double sideA, double sideB) {
            return sideA * sideB / 2;
        }
    }
}
