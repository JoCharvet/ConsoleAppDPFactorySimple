 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    /// <summary>
    /// La classe BasicGobelin représente un type de gobelin de base.
    /// </summary>
    public class BasicGobelin : Gobelin
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe BasicGobelin avec des valeurs par défaut.
        /// </summary>
        public BasicGobelin()
        {
            this.name = "un nom de gobelin";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Floor(this.lvl * 1.1);
            this.hp = this.lvl * 5;
        }
        /// <summary>
        /// Initialise une nouvelle instance de la classe BasicGobelin avec le niveau spécifié.
        /// </summary>
        /// <param name="_lvl">Le niveau du gobelin.</param>
        public BasicGobelin(int _lvl)
        {
            this.name = "un nom de gobelin";
            this.lvl = _lvl;
            this.atk = (int)Math.Floor(_lvl * 1.1);
            this.hp = _lvl * 5;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe BasicGobelin avec les paramètres spécifiés.
        /// </summary>
        /// <param name="_name">Le nom du gobelin.</param>
        /// <param name="_lvl">Le niveau du gobelin.</param>
        /// <param name="_atk">La valeur d'attaque du gobelin.</param>
        /// <param name="_hp">La valeur de points de vie du gobelin.</param>
        public BasicGobelin(string _name, int _lvl, int _atk, int _hp)
        {
            this.name = _name;
            this.lvl = _lvl;
            this.atk = _atk;
            this.hp = _hp;
        }
        /// <summary>
        /// Remplace la méthode Attack de la classe Gobelin pour BasicGobelin.
        /// </summary>
        /// <returns>les dégats qu'il doit faire</returns>
        public override int Attack()
        {
            return this.atk;
        }

        /// <summary>
        /// Remplace la méthode Die de la classe Gobelin pour BasicGobelin.
        /// </summary>
        /// <returns>Le message de mort du gobelin.</returns>
        public override string Die()
        {
            return "Eurrrhhhrrh...";
        }

        /// <summary>
        /// Remplace la méthode LooseHp de la classe Gobelin pour BasicGobelin.
        /// </summary>
        /// <param name="n">La valeur de points de vie à retirer.</param>
        /// <returns>Retourne les points de vie restants après soustraction.</returns>
        public override int LooseHp(int n)
        {
            if (this.hp - n <= 0)
            {
                this.hp = 0;
                return this.hp;
            }

            return 0;
        }
        /// <summary>
        /// Remplace la méthode Flee de la classe Gobelin pour BasicGobelin.
        /// </summary>
        /// return>Le message de fuite du gobelin.</returns>
        public override string Flee()
        {
            return "Le gobelin prend la fuite";
        }


    }
}
