using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    public class BasicOrc : Orc
    {

        public BasicOrc()
        {
            this.name = "un nom d'orc";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Round(this.lvl * 1.3);
            this.hp = this.lvl * 15;
        }

        public BasicOrc(int _lvl)
        {
            this.name = "un nom d'orc";
            this.lvl = _lvl;
            this.atk = (int)Math.Round(_lvl * 1.3);
            this.hp = _lvl * 15;
        }
        public BasicOrc(string _name, int _lvl, int _atk, int _hp)
        {
            this.name = _name;
            this.lvl = _lvl;
            this.atk = _atk;
            this.hp = _hp;
        }
        public override int Attack()
        {
            return this.atk + new Random().Next(1, 6);
        }

        public override string Die()
        {
            return "OAAARRGGGHHHhhhh....";
        }
        public override int LooseHp(int _nb)
        {
            throw new NotImplementedException();
        }

        public override void Rage()
        {
            this.atk += (int)Math.Floor(this.atk * 0.2);
            Console.WriteLine("L'orc enrage.");

        }

        
    }
}
