using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{

    /// <summary>
    /// Classe abstraite représentant un Gobelin.
    /// </summary>
    public abstract class Gobelin : Monster
    {
        /// <summary>
        /// Méthode abstraite pour permettre au Gobelin de fuir.
        /// </summary>
        /// <returns>Une chaine de caractère représentant le message de fuite.</returns>
        public abstract string Flee();
    }
}
