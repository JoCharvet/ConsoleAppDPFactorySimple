using ConsoleAppDPFactorySimple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppDPAbstractFactory
{

    // Cette classe abstraite sert de modèle pour les usines à monstres. 
    // Elle contient des méthodes abstraites pour la génération de gobelins et d'orc, qui seront implémentées par les sous-classes
    public abstract class MonsterFactory
    {
        // Méthode abstraite pour la génération d'un gobelin en fonction du niveau du héros
        public abstract Gobelin GenerateGobelin(int _herolvl);

        // Méthode abstraite pour la génération d'un orc en fonction du niveau du héros
        public abstract Orc GenerateOrc(int _herolvl);
    }
}
