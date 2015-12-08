using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleForm;

namespace TriangleUnitTesting{

    [TestClass]
    public class TriangleTest{

        [TestMethod]
        public void CalculateHypotenuseTest() {
            Triangle t = new Triangle();
            Assert.AreEqual(98, (int)t.CalculateHypotenuse(70, 70));
        }
    }
}
