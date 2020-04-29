using Xunit;

namespace dar
{
    [Trait("category", "functional")]
    public abstract class DominantTest<TDar> : DominantTestBase<TDar> where TDar : IDar, new()
    {
        [Fact]
        public void Dominant_Exist()
        {
            var data = new[] { 3, 4, 3, 2, 3, -1, 3, 3 };
            var d = Impl.GetDominantIndex(data);
            Assert.Equal(3, data[d]);
        }

        [Fact]
        public void Dominant_Not_Exist()
        {
            var d = Impl.GetDominantIndex(new[] { 0, 0, 0, -1, 3, -1, 3, 3 });
            Assert.Equal(-1, d);
        }

        [Fact]
        public void Dominant_Half_NotExists()
        {
            var d = Impl.GetDominantIndex(new[] { 0, 0, 0, 0, 3, -1, 3, 3 });
            Assert.Equal(-1, d);
        }

        [Fact]
        public void Dominant_Single()
        {
            var d = Impl.GetDominantIndex(new[] { 0 });
            Assert.Equal(0, d);
        }

        [Fact]
        public void Dominant_Empty()
        {
            var d = Impl.GetDominantIndex(new int[] { });
            Assert.Equal(-1, d);
        }

        [Fact]
        public void Dominant_Chess()
        {
            var data = new int[] { 0, 1, 0, 1, 0, 1, 1 };
            var d = Impl.GetDominantIndex(data);
            Assert.Equal(1, data[d]);
        }

        [Fact]
        public void Dominant_Long()
        {
            var data = new int[] { 2, 2, 2, 1, 1, 1, 2, 2, 2 };
            var d = Impl.GetDominantIndex(data);
            Assert.Equal(2, data[d]);
        }


        [Fact]
        public void Dominant_Long2()
        {
            var data = new int[] { 2, 3, 3, 2, 2, 1, 3, 3, 4, 3, 3, 3, 3, 2, 2 };
            var d = Impl.GetDominantIndex(data);
            Assert.Equal(3, data[d]);
        }

        [Fact]
        public void Dominant_Long3()
        {
            var data = new int[] { 2, 3, 2, 3, 3, 3, 2, 2, 2 };
            var d = Impl.GetDominantIndex(data);
            Assert.Equal(2, data[d]);
        }
    }
}
