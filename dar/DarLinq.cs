using System.Linq;

namespace dar
{
    public class DarLinq : IDar
    {
        public int GetDominantIndex(int[] ar) => ar
                .Select((s, i) => new { s, i })
                .GroupBy(s => s.s, (s, q) => new { s, q.First().i, count = q.Count() })
                .SingleOrDefault(s => s.count > ar.Length / 2)?.i ?? -1;
    }

}
