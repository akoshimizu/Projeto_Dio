using Jogo_RPG;
using Jogo_RPG.src.Entities;

Knight knight01 = new Knight( "Lancelot", 50, 81, 260, 25);
Knight knight02 = new Knight( "Donatelo", 48, 70, 230, 20);

Mage mage01 = new Mage("Gandalf", 89, 20, 90, 180);

Assassin assassin01 = new Assassin("Zed", 50, 120, 130, 10);

Boss boss01 = new Boss("Cavaleiro Gwyn", 72, 45, 2500, 10);

knight01.Status();
mage01.Status();
assassin01.Status();

Console.WriteLine();
Console.WriteLine("Boss Final, Cavaleiro Gwyn!!!");
boss01.Status();

Console.WriteLine();

while(boss01.Health>0)
{
    Random rnd = new Random();
    int num1 = rnd.Next(1,10);
    
    if (num1>03)
    {
        boss01.Health = boss01.Health - knight01.AttackDamage;
        knight01.Attack();
        if(boss01.Health<=0) continue;
        boss01.Health = boss01.Health - mage01.MagicPower;
        mage01.Attack();
        if(boss01.Health<=0) continue;
        boss01.Health = boss01.Health - assassin01.AttackDamage;
        assassin01.Attack();
        if(boss01.Health<=0) continue;
        Console.WriteLine($"Vida Boss: {boss01.Health}\n");
    }
    else{
        Console.WriteLine("Os Ataques Falharam!!!!!!");
        Console.WriteLine();
    }
    
}
Console.WriteLine();
Console.WriteLine("Boss Derrotado");




Console.ReadKey();
        