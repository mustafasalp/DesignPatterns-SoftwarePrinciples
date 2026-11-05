using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Singleton
{
    public sealed class EagerSingleton
    {
        private static readonly EagerSingleton instance = new EagerSingleton(); // create the instance at compile time

        static EagerSingleton() // Static constructor yazarsan derleyici bu bayrağı koymaz.O zaman CLR, static başlatmayı tam olarak tipe ilk erişildiği anda yapmak zorundadır(precise initialization).
        { // İçi boş olsa bile varlığı yeterli. Amaç, nesnenin gerçekten ilk Instance erişiminde oluşmasını sağlamak, yani eager’ı olabildiğince “lazy’ye yaklaştırmak”.
        }

        private EagerSingleton()
        {
        }

        public static EagerSingleton Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
