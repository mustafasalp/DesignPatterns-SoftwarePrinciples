using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class LazyTypeSingleton
    {
        private static readonly Lazy<LazyTypeSingleton> lazy =
        new Lazy<LazyTypeSingleton>(() => new LazyTypeSingleton());

        public static LazyTypeSingleton Instance { get { return lazy.Value; } }

        private LazyTypeSingleton()
        {
        }
    }
}
