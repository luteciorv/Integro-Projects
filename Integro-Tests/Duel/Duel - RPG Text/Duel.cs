using System;

namespace Duel___RPG_Text
{
    class Duel
    {        
        static void Main(string[] args)
        {
            // Criar o jogador
            Character player = new Character();

            // Nome do jogador
            Console.Write("Digite o seu nome: ");
            player.Name = Console.ReadLine();

            // Adicionar informações ao jogador
            player.Health      = new Random().Next(30, 51);
            player.Power       = new Random().Next(8, 11); ;
            player.Endurance   = new Random().Next(1, 6); ;
            player.DodgeChance = new Random().Next(10, 26); ;

            // Criar o inimigo 
            Character enemy = new Character();

            // Nome
            enemy.Name = "Goblin";

            // Adicionar informações ao jogador
            enemy.Health = new Random().Next(30, 51);
            enemy.Power = new Random().Next(8, 11); ;
            enemy.Endurance = new Random().Next(1, 6); ;
            enemy.DodgeChance = new Random().Next(10, 26); ;

            bool running = true;

            Console.WriteLine("\n===== INICIAR COMBATE =====");

            while (running)
            {
                // Mostrar a vida de ambos
                Console.WriteLine($"\n##### VIDA DO JOGADOR ##### \n{player.Health}");
                Console.WriteLine($"\n##### VIDA DO INIMIGO ##### \n{enemy.Health}");

                // Jogador ataca o Goblin
                Console.Write($"\nPressione ENTER para Atacar o {enemy.Name}: ");
                Console.ReadLine();
                enemy.TakeDamage(player.Power);

                // Goblin ataca o Jogador
                Console.WriteLine($"O {enemy.Name} atacou o {player.Name}!");
                player.TakeDamage(enemy.Power);

                // Mostrar a vida de ambos
                Console.WriteLine($"\n##### VIDA DO JOGADOR ##### \n{player.Health}");
                Console.WriteLine($"\n##### VIDA DO INIMIGO ##### \n{enemy.Health}");

                running = player.Health > 0 && enemy.Health > 0;

                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("FIM DE JOGO");
        }
    }
}
