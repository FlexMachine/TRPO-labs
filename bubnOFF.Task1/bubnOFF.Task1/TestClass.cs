using NUnit.Framework;
using ProductionCode;
using System;

namespace bubnOFF.Task1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void testCorrect()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6.0;

            Triangle triangle = new Triangle();
                     triangle.SetSides(a, b, c);
            double actual = triangle.Area();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void testFormatException()
        {
            double a = -3, b = 4, c = 5;
            Triangle triangle = new Triangle();
            
            Assert.That(() => triangle.SetSides(a, b, c), Throws.InstanceOf<FormatException>());
        }
        [Test]
        public void testArgumentException()
        {
            double a = 3, b = 4, c = 50;
            Triangle triangle = new Triangle();

            Assert.That(() => triangle.SetSides(a, b, c), Throws.InstanceOf<ArgumentException>());
        }
    }
}
