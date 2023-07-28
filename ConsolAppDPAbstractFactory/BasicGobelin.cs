 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    public class BasicGobelin : Gobelin
    {
        public BasicGobelin()
        {
            this.name = "un nom de gobelin";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Floor(this.lvl * 1.1);
            this.hp = this.lvl * 5;
        }
        public BasicGobelin(int _lvl)
        {
            this.name = "un nom de gobelin";
            this.lvl = _lvl;
            this.atk = (int)Math.Floor(_lvl * 1.1);
            this.hp = _lvl * 5;
        }
        public BasicGobelin(string _name, int _lvl, int _atk, int _hp)
        {
            this.name = _name;
            this.lvl = _lvl;
            this.atk = _atk;
            this.hp = _hp;
        }
        public override int Attack()
        {
            return this.atk;
        }

        public override string Die()
        {
            return "Eurrrhhhrrh...";
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
        public override void Flee()
        {
            Console.WriteLine("Le gobelin prend la fuite");
        }


    }
}
