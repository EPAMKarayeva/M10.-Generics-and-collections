using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_3
{
    public class FibonacciRow
    {
        public IEnumerable<int> CountNumbers(int n)
        {
            int a = 0, b = 1, c, i;

            if (n == 0)
            {
                yield return a;
            }

            for (i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;

                yield return b;
            }
        }
    }
}
