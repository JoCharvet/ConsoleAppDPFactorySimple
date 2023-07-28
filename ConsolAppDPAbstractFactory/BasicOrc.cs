using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    /// <summary>
    /// La classe `BasicOrc` est une classe concrète qui étend la classe abstraite `Orc`.
    /// </summary>
    public class BasicOrc : Orc
    {
        /// <summary>
        /// Constructeur sans paramètre de la classe `BasicOrc`
        /// </summary>
        public BasicOrc()
        {
            this.name = "un nom d'orc";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Round(this.lvl * 1.3);
            this.hp = this.lvl * 15;
        }

        /// <summary>
        /// Constructeur de la classe `BasicOrc` en fonction du niveau voulue.
        /// </summary>
        /// <param name="_lvl">Niveau de l'orc.</param>
        public BasicOrc(int _lvl)
        {
            this.name = "un nom d'orc";
            this.lvl = _lvl;
            this.atk = (int)Math.Round(_lvl * 1.3);
            this.hp = _lvl * 15;
        }

        /// <summary>
        /// Constructeur de la classe `BasicOrc`.
        /// </summary>
        /// <param name="_name">Nom de l'orc.</param>
        /// <param name="_lvl">Niveau de l'orc.</param>
        /// <param name="_atk">Points d'attaques de l'orc.</param>
        /// <param name="_hp">Points de vie de l'orc.</param>
        public BasicOrc(string _name, int _lvl, int _atk, int _hp)
        {
            this.name = _name;
            this.lvl = _lvl;
            this.atk = _atk;
            this.hp = _hp;
        }

        /// <summary>
        /// Cette méthode décrit l'attaque de l'orc.
        /// </summary>
        /// <returns>Les points d'attaques de l'orc + un nombre aléatoire entre 1 et 6.</returns>
        public override int Attack()
        {
            return this.atk + new Random().Next(1, 6);
        }

        /// <summary>
        /// Cette méthode décrit la mort de l'orc.
        /// </summary>
        /// <returns>Une chaîne de caractères d'une imitation de cri.</returns>
        public override string Die()
        {
            return "OAAARRGGGHHHhhhh....";
        }

        /// <summary>
        /// Cette méthode décrit le nombre de points de vie perdus.
        /// </summary>
        /// <param name="_nb">Nombre de points de vie perdus.</param>
        /// <returns>Les points de vie de l'orc mins le nombre de points de vie perdus.</returns>
        public override int LooseHp(int _nb)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cette méthode décrit la colère de l'orc et l'effet sur ses stats.
        /// </summary>     
        public override string Rage()
        {
            this.atk += (int)Math.Floor(this.atk * 0.2);
            return "L'orc enrage.";
        }
    }
}
