using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payers.Entities
{
    class CompanyTaxPayer : TaxPayers
    {
        // Informações do contribuinte judicial
        public int NumberOfEmployees { get; set; }

        // Método construtor #1
        public CompanyTaxPayer()
        {

        }

        // Método construtor #1
        public CompanyTaxPayer(string name, float anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override float TaxTotal()
        {
            // Valor do imposto
            float taxValue = (NumberOfEmployees <= 10) ? 0.16f : 0.14f;

            // Valor total
            return AnualIncome * taxValue;           
        }
    }
}
