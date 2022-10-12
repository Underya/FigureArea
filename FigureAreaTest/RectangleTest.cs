using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureArea;

namespace FigureAreaTest
{
    public class RectangleTest
    {
        [TestCase(1, 1, 1)]
        [TestCase(5, 5, 25)]
        public void Area_ReturnCorrect(decimal a, decimal b, decimal result)
        {
            Rectangle rectangle = new Rectangle(a, b);

            Assert.AreEqual(result, rectangle.Area);
        }

        [TestCase(0, 1)]
        [TestCase(-1, 1)]
        [TestCase(1, 0)]
        [TestCase(1, -1)]
        public void Constructor_aOrbLessNull_ThrowException(decimal a, decimal b)
        {

            Assert.Throws<FigureArgumentException>(() => new Rectangle(a, b));
        }
    }
}
