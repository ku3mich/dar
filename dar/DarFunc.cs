using System.Collections.Generic;
using System.Linq;

namespace dar
{
    public class DarFunc : IDar
    {
        public int GetDominantIndex(int[] ar)
        {
            if (ar.Length == 0)
                return -1;

            if (ar.Length == 1)
                return 0;

            // copy
            ar = ar.OrderBy(s => s).ToArray();

            var half = ar.Length / 2;

            int count(int i)
            {
                if (i >= ar.Length)
                    return 0;

                var j = ar[i];
                var k = i + 1;
                while (k < ar.Length && ar[k] == j)
                    k++;

                return k - i;
            }

            int j = 0, l;
            while ((l = count(j)) > 0)
            {
                if (l > half)
                    return j;

                j += l;
            }

            return -1;
        }
    }

}
