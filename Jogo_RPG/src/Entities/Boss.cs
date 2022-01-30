namespace Jogo_RPG.src.Entities
{
    public class Boss : Characters
    {
        public Boss (string Name, int Level, int AttackDamage, int Health, int MagicPower)
        {

            this.Name = Name;
            this.Level = Level;
            this.AttackDamage = AttackDamage;
            this.Health = Health;
            this.MagicPower = MagicPower;
        }

        public override void Status()
        {
            Console.WriteLine($"Nome: {this.Name}");
            Console.WriteLine($"Level: {this.Level}");
            Console.WriteLine($"Vida: {this.Health}");
            Console.WriteLine($"Dano de Ataque: {this.AttackDamage}");
            Console.WriteLine($"Poder Mágico: {this.MagicPower}");
            Console.WriteLine("--------------------");
        }
    }
}