using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Singleton.Ducks
{
    abstract class Duck
    {
        public string Name { get; }

        public Duck(string name)
        {
            Name = name;
        }
    }
}
