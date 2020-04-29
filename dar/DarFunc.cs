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

            var ta = ar.Select((s, i) => (s, i)).OrderBy(s => s.s).ToArray();

            var half = ar.Length / 2;

            int count(int i)
            {
                if (i >= ta.Length)
                    return 0;

                var j = ta[i].s;
                var k = i + 1;
                while (k < ta.Length && ta[k].s == j)
                    k++;

                return k - i;
            }

            int j = 0, l;
            while ((l = count(j)) > 0)
            {
                if (l > half)
                    return ta[j].i;

                j += l;
            }

            return -1;
        }
    }

}
