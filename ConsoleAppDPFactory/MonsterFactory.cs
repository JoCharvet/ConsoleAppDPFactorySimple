using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactory
{
    public abstract class MonsterFactory
    {
        Random r = new Random();
        public abstract Monster InstantiateMonster(int _playerlvl);
    }
}
