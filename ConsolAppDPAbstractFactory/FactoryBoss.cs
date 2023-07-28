using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    public class FactoryBoss : MonsterFactory
    {
        public override Gobelin GenerateGobelin(int _herolvl)
        {
           return new BossGobelin(_herolvl);
        }

        public override Orc GenerateOrc(int _herolvl)
        {
           return new BossOrc(_herolvl);
        }

        public Monster? GenerateBoss(int _herolvl, string _groundType)
        {
            if (_groundType == "forest")
            {
                return new BossOrc(_herolvl);
            }
            else if (_groundType == "cave")
            {
                return new BossGobelin(_herolvl);
            }
            else
            {
                return null;
            }
        }
       
    }
}
