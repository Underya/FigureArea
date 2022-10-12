using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureArea.Core;

namespace FigureArea
{
    internal class Rectangle : BaseFigure
    {
        public decimal A { get; init; }
        public decimal B { get; init; }

        public Rectangle(decimal a, decimal b)
        {
            VerifyNumber(a);
            VerifyNumber(b);
            A = a;
            B = b;
        }

        public override decimal Area => A * B;
    }
}
