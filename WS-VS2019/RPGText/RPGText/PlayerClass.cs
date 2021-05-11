namespace RPGText
{
    class PlayerClass
    {
        // Nome da classe
        public string Name = "";
        
        // Atributos
        public int Strength;
        public int Intelligence;
        public int Agility;

        // Informaçõe de Combate
        public int PhysicalDMG;
        public int MagicDMG;
        public float MissChance;

        public PlayerClass(PlayerRace race, int selectedClass)
        {
            // Escolher classe
            switch (selectedClass)
            {
                case (1):
                    Warrior();
                    break;

                case (2):
                    Mage();
                    break;

                case (3):
                    Rogue();
                    break;
            }

            // Adicionar modificadores
            Strength     += race.StrModifier;
            Intelligence += race.IntModifier;
            Agility      += race.AgiModifier;
        }

        private void Warrior()
        {
            // Nome da classe
            Name = "Guerreiro";

            // Atributos
            Strength     = 10;
            Intelligence = 4;
            Agility      = 6;

            // Informações de Combate
            PhysicalDMG = 10;
            MagicDMG = 2;
            MissChance = 5f;
        }

        private void Mage()
        {
            // Nome da classe
            Name = "Mago";

            // Atributos
            Strength = 4;
            Intelligence = 10;
            Agility = 6;

            // Informações de Combate
            PhysicalDMG = 2;
            MagicDMG = 10;
            MissChance = 15f;
        }

        private void Rogue()
        {
            // Nome da classe
            Name = "Ladino";

            // Atributos
            Strength = 4;
            Intelligence = 6;
            Agility = 10;

            // Informações de Combate
            PhysicalDMG = 5;
            MagicDMG = 5;
            MissChance = 25f;
        }
    }
}