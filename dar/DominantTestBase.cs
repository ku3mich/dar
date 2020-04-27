using Xunit;

namespace dar
{
    public abstract class DominantTestBase
    {
        protected readonly IDar Impl;

        protected DominantTestBase(IDar instance)
        {
            Impl = instance;
        }

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
    }
}
