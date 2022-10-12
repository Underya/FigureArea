using FigureArea.Core;

namespace FigureArea;

public class Circle : BaseFigure
{
    public decimal R { get; init; }

    public Circle(decimal r)
    {
        VerifyNumber(r);
        R = r;
    }

    public override decimal Area => (decimal)Math.PI * R * R;
}