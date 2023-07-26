using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactorySimple
{
    public class Gobelin : Monster
    {
        public Gobelin()
        {
            this.name = "un nom de gobelin";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Floor(this.lvl * 1.1);
            this.hp = this.lvl * 5;
        }
        public override int Attack()
        {
            return this.atk ;
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
    }
}
