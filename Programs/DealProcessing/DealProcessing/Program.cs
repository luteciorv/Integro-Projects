using System;
using System.Globalization;
using Entities;
using Services;

namespace DealProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### CONTRACT #####");

            // Informações do contrato
            Console.WriteLine("\nEnter contract data");
            
            // Número do contrato
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            
            // Data do contrato
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Valor do contrato
            Console.Write("Contract value: ");
            float contractValue = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // Número de parcelas
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            // Instanciar contrato
            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            // Servico do contrato
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            // Parceirlas
            Console.WriteLine("\n----- Installments -----");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
