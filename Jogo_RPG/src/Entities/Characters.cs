namespace Jogo_RPG.src.Entities
{
    public abstract class Characters
    {
        public string? Name {get; set;}
        public int Level {get; set;}
        public int AttackDamage {get; set;}
        public int Health {get; set;}
        public int MagicPower{get; set;}


        public virtual void Status()
        {
            Console.WriteLine($"Nome: {this.Name}");
            Console.WriteLine($"Level: {this.Level}");
            Console.WriteLine($"Vida: {this.Health}");
            Console.WriteLine($"Dano de Ataque: {this.AttackDamage}");
            Console.WriteLine($"Poder Mágico: {this.MagicPower}");
            Console.WriteLine("--------------------");
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{this.Name} causou dano de: {this.AttackDamage} ");
        }

    }
}