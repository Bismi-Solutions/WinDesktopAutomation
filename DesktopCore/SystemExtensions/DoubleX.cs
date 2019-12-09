using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BismiSolutions.DesktopCore.SystemExtensions
{
    public static class DoubleX
    {
        public static bool IsInvalid(this double @double)
        {
            return @double == double.PositiveInfinity || @double == double.NegativeInfinity || double.IsNaN(@double);
        }
    }
}
