﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactorySimple
{
    public class Orc : Monster
    {

        public Orc()
        {
            this.name = "un nom d'orc";
            this.lvl = new Random().Next(1,100);
            this.atk = (int)Math.Round(this.lvl * 1.3);
            this.hp = this.lvl * 15;
        }

        public Orc( int _lvl)
        {
            this.name = "un nom d'orc";
            this.lvl = _lvl;
            this.atk = (int)Math.Round(_lvl * 1.3);
            this.hp = _lvl*15;
        }
        public Orc(string _name, int _lvl, int _atk, int _hp)
        {
            this.name = _name;
            this.lvl = _lvl;
            this.atk = _atk;
            this.hp = _hp;
        }
        public override int Attack()
        {
            return this.atk + new Random().Next(1, 10);
        }

        public override string Die()
        {
            return "OAAARRGGGHHHhhhh....";
        }

        public override int LooseHp(int n)
        {
            throw new NotImplementedException();
        }
    }
}
