using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class NonThreadSafeSingleton
    {
        private NonThreadSafeSingleton() { }

        private static NonThreadSafeSingleton _instance = null;
        public static NonThreadSafeSingleton GetInstance()
        {
            if (_instance == null) // ilkse oluştur onu dön.
            {
                _instance = new NonThreadSafeSingleton();
            }
            return _instance;
        }

        public void someBusinessLogic()
        {

        }
    }
}
