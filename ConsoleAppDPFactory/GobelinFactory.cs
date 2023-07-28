﻿using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactory
{
    public class GobelinFactory : MonsterFactory
    {
        Random r = new Random();
        public override Monster InstantiateMonster(int _playerlvl)
        {
            if (_playerlvl < 4)
            {
                return new Gobelin(1);
            }
            int gobelinlvl = r.Next(_playerlvl - 4, _playerlvl +2);
            return new Gobelin(gobelinlvl);
        }
    }
}
