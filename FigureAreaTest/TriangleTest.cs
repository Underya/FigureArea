using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureArea;

namespace FigureAreaTest
{
    public class TriangleTest
    {
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void Constructor_ParamsLessNull_ThrowException(decimal a, decimal b, decimal c)
        {
            Assert.Throws<FigureArgumentException>(() => { new Triangle(a, b, c); });
        }

        [TestCase(3, 4, 5, 6)]
        public void Area_Return_CorrectResult(decimal a, decimal b, decimal c, decimal result)
        {
            Triangle triangle = new Triangle(a, b, c);

            Assert.AreEqual(result, triangle.Area);
        }

        [TestCase(7, 24, 25)]
        [TestCase(3, 4, 5)]
        public void RightTriangle_Return_True(decimal a, decimal b, decimal c)
        {
            Triangle triangle = new Triangle(a, b, c);

            Assert.True(triangle.RightTriangle);
        }

        [TestCase(7, 24, 24)]
        [TestCase(3, 4, 6)]
        public void RightTriangle_NotRight_ReturnFale(decimal a, decimal b, decimal c)
        {
            Triangle triangle = new Triangle(a, b, c);

            Assert.False(triangle.RightTriangle);
        }
    }
}
