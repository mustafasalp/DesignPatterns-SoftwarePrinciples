using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class SimpleThreadSafelyViaLockingh
    {

        private SimpleThreadSafelyViaLockingh() { }
        private static SimpleThreadSafelyViaLockingh _instance = null;
        private static readonly object padlock = new object();

        public static SimpleThreadSafelyViaLockingh Instance
        {
            get
            {
                lock (padlock) // only one thread can enter this block of code at a time
                {
                    if (_instance == null) // The problem is, we always lock(might get slow) weather the instance is created or not.
                    {                      // So, we can improve this by using double check locking.
                        _instance = new SimpleThreadSafelyViaLockingh();
                    }
                    return _instance;
                }
            }
        }

    }
}
