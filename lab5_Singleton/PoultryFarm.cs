using lab5_Singleton.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab5_Singleton
{
    class PoultryFarm
    {
        static object locker = new();
        private Duck[] ducks;
        private static PoultryFarm farm;
        static int count;

        static public int Count
        {
            get
            {
                return count;
            }
            protected set
            {
                count = value;
            }
        }
        private PoultryFarm()
        {
            count++;
        }

        public static PoultryFarm Get()
        {
            if (farm == null)
            {
                lock (locker)
                {
                    if (farm == null) 
                    {
                        farm = new PoultryFarm();
                    }
                }
            }
            return farm;
        }

        public void Add(Duck[] ducks)
        {
            this.ducks = ducks;
        }

        public void Info()
        {
            Console.WriteLine("Утки: ");
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Name);
            }
        }
    }
}
