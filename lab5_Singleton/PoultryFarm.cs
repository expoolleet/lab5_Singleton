using lab5_Singleton.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Singleton
{
    class PoultryFarm
    {
        static object locker = new();
        private Duck[] ducks;
        private static PoultryFarm farm;
        private PoultryFarm(Duck[] duckArray)
        {
            ducks = duckArray;
        }
  
        public static PoultryFarm Get(Duck[] ducks)
        {
            if (farm == null)
            {
                lock (locker)
                {
                    farm = new PoultryFarm(ducks);
                }
            }
            return farm;

        }

        public void Info()
        {
            Console.WriteLine("Утки: ");
           foreach(var duck in ducks)
            {
                Console.WriteLine(duck.Name);
            }
        }
    }
}
