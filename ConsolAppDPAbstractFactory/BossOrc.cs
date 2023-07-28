using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    // Classe BossOrc, hérite de la classe Orc
    // Représente un Orc chef de guerre
    public class BossOrc : Orc
    {
        // Constructeur par défaut, initialise les attributs lv, atk et hp
        public BossOrc()
        {
            this.name = "un nom de Chef orc";
            this.lvl = new Random().Next(1, 100);
            this.atk = (int)Math.Round(this.lvl * 1.3);
            this.hp = this.lvl * 20;
        }

        // Constructeur avec un niveau personnalisé
        // Initialise les attributs lv, atk et hp en fonction du niveau spécifié
        public BossOrc(int _lvl)
        {
            this.name = "un nom de Chef orc";
            this.lvl = _lvl;
            this.atk = (int)Math.Round(_lvl * 2.3);
            this.hp = _lvl * 20;
        }

        // Constructeur avec des attributs personnalisés
        // Initialise les attributs lv, atk et hp en fonction des valeurs spécifiées
        public BossOrc(string _name, int _lvl, int _atk, int _hp)
        {
            this.name = _name;
            this.lvl = _lvl;
            this.atk = _atk;
            this.hp = _hp;
        }

        // Méthode Attack, retourne l'attaque de l'Orc Boss avec un ajout aléatoire de dégâts
        public override int Attack()
        {
            return this.atk + new Random().Next(5, 16);
        }

        // Méthode Die, utilisée pour indiquer la mort de l'Orc Boss
        public override string Die()
        {
            return "OAAARRGGGHHHhhhh....de boss";
        }

        // Méthode LooseHp, pas encore implémentée pour le Boss Orc
        public override int LooseHp(int _nb)
        {
            throw new NotImplementedException();
        }

        // Méthode Rage, augmente l'attaque de l'Orc Boss de 40%
        // et imprime le message "Le boss Orc enrage."
        public override string Rage()
        {
            this.atk += (int)Math.Floor(this.atk * 0.4);
            return "Le boss Orc enrage.";
        }

        // Méthode SpecialBossOrcAttack, utilise Attack pour obtenir l'attaque de l'Orc Boss
        // en ajoutant 100 à la valeur d'attaque."
        public int SpecialBossOrcAttack()
        {
         
            return Attack() + 100;
        }
    }
}
