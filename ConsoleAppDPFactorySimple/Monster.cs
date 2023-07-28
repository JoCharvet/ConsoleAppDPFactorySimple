using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDPFactorySimple
{
    
// Classe abstraite qui décrit un monstre
    public abstract class Monster
    {
        // Nom du monstre
        protected string name;

        // Points de vie du monstre
        protected int hp;

        // Niveau du monstre
        protected int lvl;

        // Points d'attaque du monstre
        protected int atk;

        // Méthode abstraite qui décrit l'attaque d'un monstre
        abstract public int Attack();

        // Méthode abstraite qui décrit le nombre de points de vie qu'un monstre perd
        abstract public int LooseHp(int _nb);

        // Méthode abstraite qui décrit la mort d'un monstre
        abstract public string Die();

        // Méthode qui retourne une chaîne de caractères qui représente les attributs d'un objet de la classe 'Monster'
        public override string ToString()
        {
            return "Monster : " + this.name + " lvl : " + this.lvl + " hp : " + this.hp + " atk : " + this.atk;
        }
    }
}
