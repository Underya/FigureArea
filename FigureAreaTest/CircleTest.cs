using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureArea;

namespace FigureAreaTest
{
    public class CircleTest
    {
        [TestCase(1, 3.142)]
        [TestCase(3, 28.274)]
        public void Area_Return_right(decimal r, decimal result)
        {
            Circle circle = new Circle(r);

            Assert.AreEqual(result, Decimal.Round(circle.Area, 3));
        }
    }
}
