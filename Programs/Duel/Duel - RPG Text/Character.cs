using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel___RPG_Text
{
    class Character
    {
        // Informações
        public string Name;
        public int Health;

        // Atributos
        public int Power;
        public int Endurance;
        public float DodgeChance;

        // Realiza um ataque
        public int Attack()
        {
            return Power;
        }

        public void TakeDamage(int damage)
        {
            // Verificar se esquivou
            if(new Random().Next(0, 101) <= DodgeChance)
            {
                Console.WriteLine($"O {Name} desviou do golpe");
                return;
            }

            // Verificar se é golpe crítico
            if(new Random().Next(0, 21) >= 16)
            {
                Console.WriteLine($"O {Name} levou dano crítico!");
                damage *= 2;
            }

            // Perder vida
            Console.WriteLine($"Dano causado: {damage - Endurance}");
            Health -= (damage - Endurance);
        }        
    }
}
