// See https://aka.ms/new-console-template for more information
using ConsoleAppDPFactory;
using ConsoleAppDPFactorySimple;


Console.WriteLine("Générateur de monstre");
Console.WriteLine(" Notre Heros niveau : 10 pv :150 atk:12 ");

Monster monsterA = chooseFactory(10);
Monster monsterB = chooseFactory(10);
Monster monsterC = chooseFactory(10);
Monster monsterD = chooseFactory(10);
Monster monsterE = chooseFactory(10);
Monster monsterF = chooseFactory(10);
Monster monsterG = chooseFactory(10);

Console.WriteLine(monsterA.ToString());
Console.WriteLine(monsterB.ToString());
Console.WriteLine(monsterC.ToString());
Console.WriteLine(monsterD.ToString());
Console.WriteLine(monsterE.ToString());
Console.WriteLine(monsterF.ToString());
Console.WriteLine(monsterG.ToString());

Console.ReadLine();

Monster chooseFactory(int heroslvl)
{
    if (new Random().Next(0, 2) == 0)
    {
        return new GobelinFactory().InstantiateMonster(heroslvl);
    }
    else
    {
        return new OrcFactory().InstantiateMonster(heroslvl);
    }
}