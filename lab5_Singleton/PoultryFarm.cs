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
        private string[] ducks;
        private static PoultryFarm farm;
        private PoultryFarm(string[] ducksArray)
        {
            ducks = new string[ducksArray.Length];
            for (int i = 0; i < ducksArray.Length; i++)
            {
                ducks[i] = ducksArray[i];
            }
        }
  
        public static PoultryFarm Get(string[] ducks)
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
            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine($"{i+1}. {ducks[i]}");
            }
        }
    }
}
