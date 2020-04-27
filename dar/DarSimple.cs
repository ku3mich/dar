using System.Collections.Generic;

namespace dar
{
    public class DarSimple : IDar
    {
        public int GetDominantIndex(int[] ar)
        {
            // not a fan to check nulls ;)
            if (ar.Length == 0)
                return -1;

            if (ar.Length == 1)
                return 0;

            var counts = new Dictionary<int, (int, int)>();
            var half = ar.Length / 2;
            for (var c = 0; c < ar.Length; c++)
            {
                var e = ar[c];
                if (counts.ContainsKey(e))
                {
                    (var k, var v) = counts[e];
                    if (v == half)
                        return k;
                    counts[e] = (k, v + 1);
                }
                else
                    counts.Add(e, (c, 1));
            }

            return -1;
        }
    }

}
