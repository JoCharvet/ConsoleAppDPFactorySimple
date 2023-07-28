using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    public abstract class MonsterFactory
    {
        public abstract Gobelin GenerateGobelin(int _herolvl);

        public abstract Orc GenerateOrc(int _herolvl);
    }
}
