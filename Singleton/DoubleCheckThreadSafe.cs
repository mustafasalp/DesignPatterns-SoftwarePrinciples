using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class DoubleCheckThreadSafe
    {
        private static DoubleCheckThreadSafe instance = null;
        private static readonly object padlock = new object();

        DoubleCheckThreadSafe()
        {
        }

        public static DoubleCheckThreadSafe Instance
        {
            get
            {
                // First check, if instance is already created, no need to lock, just return the instance.
                if (instance == null)
                {
                    // Two threads can enter this block of code at the same time, so we need to lock it.
                    lock (padlock) // If not created, then lock and check again.
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckThreadSafe();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
