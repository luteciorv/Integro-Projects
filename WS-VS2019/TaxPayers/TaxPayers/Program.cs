using System;
using System.Collections.Generic;
using Payers.Entities;

namespace Payers
{
    class Payers
    {
        static void Main(string[] args)
        {
            // Lista dos contribuintes
            List<TaxPayers> taxPayers = new List<TaxPayers>();

            Console.WriteLine("##### TAX PAYERS REGISTER #####");

            // Quantidade de contribuintes
            Console.Write("\nEnter the number of tax payers: ");
            int amountOfTaxPayers = int.Parse(Console.ReadLine());

            // Registrar cada contribuinte
            for(int i = 1; i <= amountOfTaxPayers; i++)
            {
                // Dados do contribuinte #1
                Console.WriteLine($"\nTax payer #{i} data");

                // Tipo de contribuinte
                Console.Write("Individual or Company (I/C)? ");
                char taxPaymentType = char.ToLower(char.Parse(Console.ReadLine()));

                // Nome da pessoa
                Console.Write("Name: ");
                string personName = Console.ReadLine();

                // Renda anual
                Console.Write("Anual income: ");
                float anualIncome = float.Parse(Console.ReadLine());

                // Tipo individual
                if(taxPaymentType == 'i')
                {
                    // Gastos com saúde
                    Console.Write("Health expenditures: ");
                    float healthExpenditures = float.Parse(Console.ReadLine());

                    // Adicionar esta pessoa a lista de contribuintes
                    taxPayers.Add(new IndividualTaxPayer(personName, anualIncome, healthExpenditures));
                }

                // Tipo jurídico
                else if(taxPaymentType == 'c')
                {
                    // Número de funcionários
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    // Adicionar esta pessoa a lista de contribuintes
                    taxPayers.Add(new CompanyTaxPayer(personName, anualIncome, numberOfEmployees));
                }
            }

            // Exibição
            Console.WriteLine("\n##### TAXES PAID #####");

            float totalTaxes = 0.00f;

            // Percorrer cada pessoa
            foreach(TaxPayers currentTaxPayer in taxPayers)
            {
                // Armazenar
                totalTaxes += currentTaxPayer.TaxTotal();

                // Exibir
                Console.WriteLine($"- {currentTaxPayer.Name}: ${currentTaxPayer.TaxTotal():F2}");
            }

            // Total de taxas
            Console.WriteLine($"\nTOTAL TAXES: ${totalTaxes:F2}");
        }
    }
}
