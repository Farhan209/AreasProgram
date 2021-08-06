using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AreasProgram
{
    [TestFixture]
    class TestCases
    {
        [Test]
        public void CircleTestArea()
        {
            Circle c = new Circle();
            double r = 8.0;
            double expectedValue = 201.06;
            double result = c.Area(r);
            double actualValue = Math.Round(result, 2);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CircleTestPerimeter()
        {
            Circle c = new Circle();
            double r = 8.0;
            double expectedValue = 50.27;
            double result = c.Perimeter(r);
            double actualValue = Math.Round(result, 2);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectangleTestArea()
        {
            Rectangle r = new Rectangle();
            double  l = 4.0;
            double w = 3.0;
            double expectedValue = 12;
            double actualValue = r.Area(l, w);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectangleTestPerimeter()
        {
            Rectangle r = new Rectangle();
            double l = 4.0;
            double w = 3.0;
            double expectedValue = 14;
            double actualValue = r.Perimeter(l, w);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TriangleTestArea()
        {
            Triangle t = new Triangle();
            double b = 14.0;
            double h = 15.0;
            double expectedValue = 105;
            double actualValue = t.Area(b, h);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TriangleTestPerimeter()
        {
            Triangle t = new Triangle();
            double a = 13.0;
            double b = 14.0;
            double c = 15.0;
            double expectedValue = 42;
            double actualValue = t.Perimeter(a, b, c);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
