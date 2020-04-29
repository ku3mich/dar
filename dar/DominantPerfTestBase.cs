using Xunit;

namespace dar
{
    [Trait("category", "performance")]
    public abstract class DominantPerfTestBase<TDar> : DominantTestBase<TDar> where TDar : IDar, new()
    {
        const int Iterations = 10000000;

        [Fact]
        public void Dominant_Half_NotExists_Perf()
        {
            var data = new[] { 0, 0, 0, 0, 3, -1, 3, 3 };
            for (var i = 0; i < Iterations; i++)
            {
                var d = Impl.GetDominantIndex(data);
            }
        }

        [Fact]
        public void Dominant_Half_Exists_Perf()
        {
            var data = new[] { 0, 0, 0, 0, 0, -1, 3, 3 };
            for (var i = 0; i < Iterations; i++)
            {
                var d = Impl.GetDominantIndex(data);
            }
        }

        [Fact]
        public void Dominant_Part_Exists_Perf()
        {
            var data = new[] { 0, 0, 1, 0, 0, -1, 0, 3 };
            for (var i = 0; i < Iterations; i++)
            {
                var d = Impl.GetDominantIndex(data);
            }
        }
    }
}
