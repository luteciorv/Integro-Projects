using System;

namespace RPGText
{
    class CreatePlayer
    {
        public string Name;
        public PlayerRace PRace;
        public PlayerClass PClass;

        // Método construtor
        public CreatePlayer()
        {
            // Criar uma raça
            Console.WriteLine("----- SELEÇÃO DE RAÇA -----");
            Console.WriteLine("1 - Elfo Superior \n2 - Red Guard \n3 - Khajit");            
            PRace = new PlayerRace(int.Parse(Console.ReadLine()));

            // Criar uma classe
            Console.WriteLine("\n----- SELEÇÃO DE CLASSE -----");
            Console.WriteLine("1 - Guerreiro \n2 - Mago \n3 - Ladino");
            PClass = new PlayerClass(PRace, int.Parse(Console.ReadLine()));

            // Nome do jogador
            Console.Write("Digite o seu nome: ");
            Name = Console.ReadLine();
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine("\n\n##### Informações do Jogador #####");
            Console.WriteLine($"Nome: {Name} \nRaça: {PRace.Name} \nClasse: " +
            $"{PClass.Name} \n\nForça: {PClass.Strength} \nInteligência: " +
            $"{PClass.Intelligence} \nAgilidade: {PClass.Agility} \nDano Físico: " +
            $"{PClass.PhysicalDMG} \nDano Mágico: {PClass.MagicDMG}" +
            $" \nEsquiva: {PClass.MissChance}%");
        }
    }
}
