using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    abstract class TaxPayers
    {
        // Informações dos contribuintes
        public string Name { get; protected set; }
        public float AnualIncome { get; protected set; }

        // Método Construtor #1
        public TaxPayers()
        {

        }

        // Método Construtor #2
        protected TaxPayers(string name, float anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract float TaxTotal();
    }
}
