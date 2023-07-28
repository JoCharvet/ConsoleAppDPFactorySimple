using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactory
{
    public class OrcFactory : MonsterFactory
    {
        Random r = new Random();
        public override Monster InstantiateMonster(int _playerlvl)
        {
            if(_playerlvl < 3)
            {
                return new Orc(1);
            }
           int orclvl = r.Next(_playerlvl - 3, _playerlvl );
            return new Orc(orclvl);
        }
    }
}
