using System;

namespace dar
{
    public abstract class DominantTestBase<TDar> where TDar : IDar, new()
    {
        protected readonly IDar Impl;

        protected DominantTestBase()
        {
            Impl = new TDar();
        }
    }
}
