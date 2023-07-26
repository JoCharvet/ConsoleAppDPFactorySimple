using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactorySimple
{
    public class MonsterFactory
    {
        public Monster CreateMonster(int _type)
        {
            Monster monster = null;
            switch (_type)
            {
                case 1:
                    monster = new Orc();
                    break;
                case 2:
                    monster = new Gobelin();
                    break;
                default:
                    break;
            }
            return monster;
        }
    }
}
