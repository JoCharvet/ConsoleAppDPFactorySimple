using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactorySimple
{
    public abstract class Monster
    {
        protected string name;
        protected int hp;
        protected int lvl;
        protected int atk;

        abstract public int Attack();
        abstract public int LooseHp(int _nb);
        abstract public string Die();

        public override string ToString()
        {
            return "Monster : " + this.name + " lvl : " + this.lvl + " hp : " + this.hp + " atk : " + this.atk;
        }
        
    }
}
