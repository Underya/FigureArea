using FigureArea.Core;

namespace FigureArea;

public class Triangle : BaseFigure
{
    public decimal A { get; init; }
    public decimal B { get; init; }
    public decimal C { get; init; }

    public Triangle(decimal a, decimal b, decimal c) 
    {
        VerifyNumber(a);
        VerifyNumber(b);
        VerifyNumber(c);
        A = a;
        B = b;
        C = c;
    }

    public override decimal Area
    {
        get
        {
            decimal p = (A + B + C) / 2;

            return (decimal)Math.Sqrt((double)(p * (p - A) * (p - B) * (p - C )));
        }
    }

    public bool RightTriangle
    {
        get
        {
            decimal a2 = A * A;
            decimal b2 = B * B;
            decimal c2 = C * C;

            return a2 == (b2 + c2) 
                   || b2 == (a2 + c2) 
                   || c2 == (a2 + b2);
        }
    }
}