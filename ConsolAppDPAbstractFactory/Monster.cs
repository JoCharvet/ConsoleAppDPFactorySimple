using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsolAppDPAbstractFactory
{
    /// <summary>
    /// Classe abstraite représentant un monstre.
    /// </summary>
    public abstract class Monster
    {
        /// <summary>
        /// Le nom du monstre.
        /// </summary>
        protected string name;

        /// <summary>
        /// Les points de vie du monstre.
        /// </summary>
        protected int hp;

        /// <summary>
        /// Le niveau du monstre.
        /// </summary>
        protected int lvl;

        /// <summary>
        /// L'attaque du monstre.
        /// </summary>
        protected int atk;

        /// <summary>
        /// Attaque le joueur.
        /// </summary>
        /// <returns>Les dégâts infligés.</returns>
        public abstract int Attack();

        /// <summary>
        /// Perd des points de vie.
        /// </summary>
        /// <param name="_nb">Le nombre de points de vie perdus.</param>
        /// <returns>Les points de vie restants.</returns>
        public abstract int LooseHp(int _nb);

        /// <summary>
        /// Meurt et renvoie un message de mort.
        /// </summary>
        /// <returns>Un message de mort.</returns>
        public abstract string Die();

        /// <summary>
        /// Convertit l'objet en string.
        /// </summary>
        /// <returns>Le nom, le niveau, les points de vie, et l'attaque du monstre en string.</returns>
        public override string ToString()
        {
            return "Monster : " + this.name + "--  lvl : " + this.lvl + "-- hp : " + this.hp + " atk : " + this.atk + "--";
        }
    }
}
