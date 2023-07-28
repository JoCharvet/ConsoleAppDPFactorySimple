using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    public class BossGobelin : Gobelin
    {
        public BossGobelin()
        {
            this.name = "un nom de gobelin";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Floor(this.lvl * 1.1);
            this.hp = this.lvl * 5;
        }

        public BossGobelin(int _lvl)
        {
            this.name = "un nom de Roi gobelin";
            this.lvl = _lvl;
            this.atk = (int)Math.Floor(_lvl * 1.8);
            this.hp = _lvl * 10;
        }

        public BossGobelin(string name, int lvl, int atk, int hp)
        {
            this.name = name;
            this.lvl = lvl;
            this.atk = atk;
            this.hp = hp;
        }
        public override void Flee()
        {
            Console.WriteLine("A Moi !");
            Console.WriteLine("3 gobelins apparaissent !");

        }

        public override int Attack()
        {
            return (int)Math.Floor(this.atk * 1.5);
        }

        public override string Die()
        {
            return "Eurrrhhhrrh... comme un boss Gobelin !";
        }

        public override int LooseHp(int n)
        {
            if (this.hp - n <= 0)
            {
                this.hp = 0;
                return this.hp;
            }

            return 0;
        }

        public int SpecialAttackGobelin()
        {
              return (int)Math.Floor(this.atk * 2.5)+50;
        }

       
    }
}
