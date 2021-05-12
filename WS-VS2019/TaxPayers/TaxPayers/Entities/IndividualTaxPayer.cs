using System;
using System.Text;

namespace Payers.Entities
{
    class IndividualTaxPayer : TaxPayers
    {
        // Informações do contribuinte individual
        public float HealthExpenditures { get; set; }

        // Método Construtor #1
        public IndividualTaxPayer()
        {

        }

        // Método Construtor #2
        public IndividualTaxPayer(string name, float anualIncome, float healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override float TaxTotal()
        {
            // Valor de imposto
            float taxValue = (AnualIncome < 20000f ? 0.15f : 0.25f);

            // Valor total
            return (AnualIncome * taxValue) - (HealthExpenditures * 0.5f);            
        }
    }
}
