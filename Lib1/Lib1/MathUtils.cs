using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib1
{
    public class MathUtils
    {
        public static int OnePlusOne()
        {
            var result = 1 + 1;
            return result;
        }

        public static int XPlusY(int valueX, int valueY)
        {
            var sum = valueX + valueY;
            return sum;
        }

        public static int XMinusY(int x, int y)
        {
            return x - y;
        }

        public static float XDivideY(float x, float y)
        {
            if (y == 0)
                throw new ArgumentException("Can't divide by zero");

            return x / y;
        }
    }
}
