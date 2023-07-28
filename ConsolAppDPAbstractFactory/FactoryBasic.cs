using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    public class FactoryBasic : MonsterFactory
    {
        public override Gobelin GenerateGobelin(int _herolvl)
        {
            if (_herolvl < 3)
            {
                return new BasicGobelin(1);
            }
            int gobelinlvl = new Random().Next(_herolvl - 3, _herolvl + 2);
                return new BasicGobelin(_herolvl);
        }

        public override Orc GenerateOrc(int _herolvl)
        {
           if (_herolvl < 3)
            {
                return new BasicOrc(1);
            }
            int orclvl = new Random().Next(_herolvl - 3, _herolvl);
            return new BasicOrc(_herolvl);
        }

        public Monster GenerateBasic(int _herolvl , string _groundType)
        {
            if (_groundType == "forest")
            {
               
                return GenerateOrc(_herolvl);
            }
            else if (_groundType == "cave")
            {
                 return  GenerateGobelin(_herolvl);
          
            }
            else
            {
                return null;
            }
        }
    }
}
