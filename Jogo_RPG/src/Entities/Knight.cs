namespace Jogo_RPG.src.Entities
{
    public class Knight : Characters
    {
        // public string Name {get; set;}
        // public int Level {get; set;}
        // public int AttackDamage {get; set;}
        // public int Health {get; set;}
        // public int MagicPower{get; set;}


        public Knight(string Name, int Level, int AttackDamage, int Health, int MagicPower)
        {
            this.Name = Name;
            this.Level = Level;
            this.AttackDamage = AttackDamage;
            this.Health = Health;
            this.MagicPower = MagicPower;
        }
        
        // public override string ToString()
        // {
        //     return this.Name + " " + this.Level + " " + this.AttackDamage + this.Health + " " + this.MagicPower;
        // }

        public override void Status()
        {
            Console.WriteLine($"Nome: {this.Name}");
            Console.WriteLine($"Level: {this.Level}");
            Console.WriteLine($"Vida: {this.Health}");
            Console.WriteLine($"Dano de Ataque: {this.AttackDamage}");
            Console.WriteLine($"Poder Mágico: {this.MagicPower}");
            Console.WriteLine("--------------------");
        }

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} causou dano de: {this.AttackDamage} ");
        }
    }
}