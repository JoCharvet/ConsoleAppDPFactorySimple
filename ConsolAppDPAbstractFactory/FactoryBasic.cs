using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    /// <summary>
    /// La classe FactoryBasic représente une implémentation de base d'une fabrique de monstres.
    /// </summary>
    public class FactoryBasic : MonsterFactory
    {
        /// <summary>
        /// Génère un gobelin de base en fonction du niveau spécifié.
        /// </summary>
        /// <param name="_herolvl">Le niveau du héros.</param>
        /// <returns>Le gobelin de base généré correspondant au niveau du héros.</returns>
        public override Gobelin GenerateGobelin(int _herolvl)
        {
            if (_herolvl < 3)
            {
                return new BasicGobelin(1);
            }
            int gobelinlvl = new Random().Next(_herolvl - 3, _herolvl + 2);
            return new BasicGobelin(_herolvl);
        }

        /// <summary>
        /// Génère un orc de base en fonction du niveau spécifié.
        /// </summary>
        /// <param name="_herolvl">Le niveau du héros.</param>
        /// <returns>L'orc de base généré correspondant au niveau du héros.</returns>
        public override Orc GenerateOrc(int _herolvl)
        {
            if (_herolvl < 3)
            {
                return new BasicOrc(1);
            }
            int orclvl = new Random().Next(_herolvl - 3, _herolvl);
            return new BasicOrc(_herolvl);
        }

        /// <summary>
        /// Génère un monstre de base en fonction du niveau et du type de terrain spécifiés.
        /// </summary>
        /// <param name="_herolvl">Le niveau du héros.</param>
        /// <param name="_groundType">Le type de terrain.</param>
        /// <returns>Le monstre de base généré correspondant aux paramètres spécifiés.</returns>
        public Monster GenerateBasic(int _herolvl, string _groundType)
        {
            if (_groundType == "forest")
            {
                return GenerateOrc(_herolvl);
            }
            else if (_groundType == "cave")
            {
                return GenerateGobelin(_herolvl);
            }
            else
            {
                return null;
            }
        }
    }
}
