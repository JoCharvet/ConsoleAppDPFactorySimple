using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    public class BossOrc : Orc
    {
        public BossOrc()
        {
            this.name = "un nom de Chef orc";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Round(this.lvl * 1.3);
            this.hp = this.lvl * 20;
        }

        public BossOrc(int _lvl)
        {
            this.name = "un nom de Chef orc";
            this.lvl = _lvl;
            this.atk = (int)Math.Round(_lvl * 2.3);
            this.hp = _lvl * 20;
        }
        public BossOrc(string _name, int _lvl, int _atk, int _hp)
        {
            this.name = _name;
            this.lvl = _lvl;
            this.atk = _atk;
            this.hp = _hp;
        }
        public override int Attack()
        {
            return this.atk + new Random().Next(5, 16);
        }

        public override string Die()
        {
            return "OAAARRGGGHHHhhhh....de boss";
        }
        public override int LooseHp(int _nb)
        {
            throw new NotImplementedException();
        }

        public override void Rage()
        {
            this.atk += (int)Math.Floor(this.atk*0.4);
            Console.WriteLine("Le boss Orc enrage.");
        }
        public int SpecialBossOrcAttack()
        {
            Console.WriteLine("Moi déssossé toi !");
            return Attack() + 100;
        }
    }
}
