// See https://aka.ms/new-console-template for more information
using ConsoleAppDPFactorySimple;

Console.WriteLine("Générateur de monstre");
Console.WriteLine(" Notre Heros niveau : 1 pv :22 atk:15 ");
MonsterFactory monsterFactory = new MonsterFactory();
Monster  monsterA = monsterFactory.CreateMonster(1);
Monster monsterB = monsterFactory.CreateMonster(2);

Console.WriteLine(monsterA.ToString());
Console.WriteLine(monsterB.ToString());
Console.ReadLine();
