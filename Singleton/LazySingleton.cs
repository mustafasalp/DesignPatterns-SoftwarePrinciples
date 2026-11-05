using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class LazySingleton
    {
        private LazySingleton()
        {
        }

        public static LazySingleton Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
