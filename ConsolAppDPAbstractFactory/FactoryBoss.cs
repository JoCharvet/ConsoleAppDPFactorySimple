using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{
    /// <summary>
    /// Classe FactoryBoss - une fabrique de monstres pour de grands boss.
    /// </summary>
    public class FactoryBoss : MonsterFactory
    {
        /// <summary>
        /// Générer un gobelin de boss.
        /// </summary>
        /// <param name="_herolvl">Le niveau du héros.</param>
        /// <returns>Un gobelin de boss.</returns>
        public override Gobelin GenerateGobelin(int _herolvl)
        {
            return new BossGobelin(_herolvl);
        }

        /// <summary>
        /// Génère un orc de boss.
        /// </summary>
        /// <param name="_herolvl">Le niveau du héros.</param>
        /// <returns>Un orc de boss.</returns>
        public override Orc GenerateOrc(int _herolvl)
        {
            return new BossOrc(_herolvl);
        }

        /// <summary>
        /// Générer un boss monstre pour un niveau et un type de terrain donnés.
        /// </summary>
        /// <param name="_herolvl">Le niveau du héros.</param>
        /// <param name="_groundType">Le type de terrain.</param>
        /// <returns>Un boss monstre.</returns>
        public Monster? GenerateBoss(int _herolvl, string _groundType)
        {
            if (_groundType == "forêt")
            {
                return new BossOrc(_herolvl);
            }
            else if (_groundType == "caverne")
            {
                return new BossGobelin(_herolvl);
            }
            else
            {
                return null;
            }
        }
    }
}
