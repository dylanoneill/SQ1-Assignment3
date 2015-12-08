/*
 * Project: SQ-I Assignment 3
 * File: TriangleTest.cs
 * Programmer: Dylan O'Neill
 * Date: 2015-12-05
 * Description: The methods in the file are used to test various methods within the triangle class.
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleForm;

namespace TriangleUnitTesting{

    [TestClass]
    public class TriangleTest{

        /*
         * Method: CalculateHypotenuseTest
         * Description: Used to test the calculation of the hypotenuse when Triangle is right and
         *              2 sides are given.
         * Returns: void
        */
        [TestMethod]
        public void CalculateHypotenuseTest() {
            Triangle t = new Triangle();
            Assert.AreEqual(98, (int)t.CalculateHypotenuse(70, 70));
        }

        /*
         * Method: CalculateThirdAngleTest
         * Description: Used to test the calculation of the missing angle when 2 out of the 3
         *              angles of the Triangle are given.
         * Returns: void
        */
        [TestMethod]
        public void CalculateThirdAngleTest(){
            Triangle t = new Triangle();
            Assert.AreEqual(40, (int)t.CalculateThirdAngle(70, 70));
        }

        /*
         * Method: CalculateAreaTest
         * Description: Used to test the calculation of the area when Triangle is right and
         *              sides A and B are given.
         * Returns: void
        */
        [TestMethod]
        public void CalculateAreaTest(){
            Triangle t = new Triangle();
            Assert.AreEqual(2450, (int)t.CalculateArea(70, 70));
        }

        /*
         * Method: CalculateThirdAngleExceptionTest
         * Description: Used to test that the third angle will not be calculated if the 2 given
         *              angles sum is more than or equal to 180
         * Returns: voi
        */
        [TestMethod]
        public void CalculateThirdAngleExceptionTest() {
            Triangle t = new Triangle();
            Assert.AreEqual(0, (int)t.CalculateThirdAngle(90, 90));
        }
    }
}
