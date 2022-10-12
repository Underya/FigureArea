using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class FigureArgumentException : ArgumentException
    {
        public FigureArgumentException(string message) : base(message)
        {

        }
    }
}
