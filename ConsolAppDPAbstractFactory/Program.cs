// See https://aka.ms/new-console-template for more information

using ConsolAppDPAbstractFactory;


FactoryBasic factoryBasic = new FactoryBasic();
FactoryBoss factoryBoss= new FactoryBoss();
Random r = new Random();
int nbRencontre = 0;

Console.WriteLine("Générateur de monstre");
Console.WriteLine(" Notre Heros niveau : 10 pv :150 atk:22 ");
Console.WriteLine("il avance dans le labyrinthe ,le type de sol a l'entrée est de type cave");
Console.WriteLine("on considère que tant qu'il n'a pas rencontrer 5 monstre il ne peut pas rencontrer de boss");
Monster monsterA = generateRandom(10, "cave");
Monster monsterB = generateRandom(10, "cave");
Monster monsterC = generateRandom(10, "forest");
Monster monsterD = generateRandom(10, "forest");
Monster monsterE = generateRandom(10, "forest");
Console.WriteLine(monsterA.ToString());
Console.WriteLine(monsterB.ToString());
Console.WriteLine(monsterC.ToString());
Console.WriteLine(monsterD.ToString());
Console.WriteLine(monsterE.ToString());
Console.ReadLine();


Monster generateRandom(int _herolvl ,string _ground)
{


    if (nbRencontre < 5)
    {
        return factoryBasic.GenerateBasic(_herolvl, _ground);
    }
    else
    {
        nbRencontre++;
        if (r.Next(0, 2) == 1)
        {
            return factoryBoss.GenerateBoss(_herolvl, _ground);
        }
        else
        {
            return factoryBasic.GenerateBasic(_herolvl, _ground);
        }

    }
       

    
}
