namespace RPGText
{
    class PlayerRace
    {
        public string Name;
        public int StrModifier;
        public int IntModifier;
        public int AgiModifier;

        public PlayerRace(int race)
        {
            // Escolher a raça
            switch (race)
            {
                // Elfo superior
                case (1):
                    HighElf();
                    break;

                // Redguard
                case (2):
                    Redguard();
                    break;
            
                // Khajiit
                case (3):
                    Khajiit();
                    break;
            }
        }

        #region RAÇAS
        private void HighElf()
        {
            // Nome
            Name = "Elfo Superior";

            // Atributos
            StrModifier = +0;
            IntModifier = +2;
            AgiModifier = +0;
        }

        private void Redguard()
        {
            // Nome
            Name = "Redguard";

            // Atributos
            StrModifier = +2;
            IntModifier = +0;
            AgiModifier = +0;
        }

        private void Khajiit()
        {
            // Nome
            Name = "Khajiit";

            // Atributos
            StrModifier = +0;
            IntModifier = +0;
            AgiModifier = +2;
        }
        #endregion
    }
}
