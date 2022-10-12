using FigureArea;
using FigureArea.Core;

namespace FigureAreaTest.Core
{
    public class BaseFigureTest
    {
        private class  BaseFigureMock : BaseFigure
        {
            public void VerifyNumber(Decimal number)
            {
                base.VerifyNumber(number);
            }

            public override decimal Area { get; }
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void VerifyNumber_NullOrLess_ThrowException(decimal number)
        {
            BaseFigureMock mock = new();

            Assert.Throws<FigureArgumentException>(() => { mock.VerifyNumber(number); });
        }

        [TestCase(0.001)]
        [TestCase(10000)]
        public void VerifyNumber_GrossNull_NotThrowException(decimal number)
        {
            BaseFigureMock mock = new();

            mock.VerifyNumber(number);
        }

    }
}
