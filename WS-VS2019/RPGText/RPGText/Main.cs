using System;

namespace RPGText
{
    class RPGText
    {
        static void Main(string[] args)
        {
            // Criar o jogador
            CreatePlayer player = new CreatePlayer();

            player.DisplayPlayerInfo();
        }       
    }
}
