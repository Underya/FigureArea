namespace FigureArea.Core
{
    public abstract class BaseFigure : IFigure
    {
        protected void VerifyNumber(Decimal number)
        {
            if (number <= 0m)
                throw new FigureArgumentException($"Значение параметра меньше или равно нуля! Value:{number}");

        }

        public abstract decimal Area { get; }
    }
}
