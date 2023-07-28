using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    // Classe BossGobelin hérite de la classe Gobelin
    // Les instances de BossGobelin sont des boss qui ont des caractéristiques et methode spéciales comme une attaque spéciale
    public class BossGobelin : Gobelin
    {
        // Constructeur par défaut
        public BossGobelin()
        {
            this.name = "un nom de gobelin";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Floor(this.lvl * 1.1);
            this.hp = this.lvl * 5;
        }

        // Constructeur qui prend un niveau en input
        // Le nom du Boss gobelin dépend de son niveau et ses stats calculées en fonction de ce dernier
        public BossGobelin(int _lvl)
        {
            this.name = "un nom de Roi gobelin";
            this.lvl = _lvl;
            this.atk = (int)Math.Floor(_lvl * 1.8);
            this.hp = _lvl * 10;
        }

        // Constructeur qui prend un nom, un niveau, une attaque et des points de vie en input
        public BossGobelin(string name, int lvl, int atk, int hp)
        {
            this.name = name;
            this.lvl = lvl;
            this.atk = atk;
            this.hp = hp;
        }

        // La méthode de fuite
        public override string Flee()
        {
           return "A Moi ! \r\n 3 gobelins apparaissent !";
        }

        // La méthode d'attaque
        public override int Attack()
        {
            return (int)Math.Floor(this.atk * 1.5);
        }

        // La méthode de mort du boss gobelin
        public override string Die()
        {
            return "Eurrrhhhrrh... comme un boss Gobelin !";
        }

        // La méthode pour réduire les points de vie (HP) du boss gobelin (si les points de vie sont réduits à zéro, la méthode return 0)
        public override int LooseHp(int n)
        {
            if (this.hp - n <= 0)
            {
                this.hp = 0;
                return this.hp;
            }

            return 0;
        }

        // Une méthode pour une attaque spéciale du boss gobelin
        public int SpecialAttackGobelin()
        {
            return (int)Math.Floor(this.atk * 2.5) + 50;
        }
    }
}
