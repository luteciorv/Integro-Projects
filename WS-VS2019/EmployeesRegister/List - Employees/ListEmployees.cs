using System;
using System.Collections.Generic;

namespace ListEmployees
{
    class ListEmployees
    {
        static void Main(string[] args)
        {
            // Quantidade de empregados
            Console.Write("How many employees will be registred? ");
            int amountOfEmployees = int.Parse(Console.ReadLine());

            // Lista contendo os empregados
            List<Employeer> employees = new List<Employeer>();

            // Registrar empregados
            for(int i = 0; i < amountOfEmployees; i++)
            {
                // Empregado #(i+1)
                Console.WriteLine($"\nEmployoee #{i + 1}");

                // ID
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                // Nome
                Console.Write("Name: ");
                string name = Console.ReadLine();

                // Salary
                Console.Write("Salary: ");
                float salary = float.Parse(Console.ReadLine());

                // Instanciar novo empregado
                employees.Add(new Employeer(id, name, salary));
            }

            // Ler o ID do funcionário a ser procurado
            Console.Write("\nEnter the employee ID that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            // Porcentagem do salário dele que será aumentado
            Console.Write("Enter the percentage: ");
            float percentage = float.Parse(Console.ReadLine());

            // Encontrar funcionário e aumentar o salário dele
            employees.Find(x => x.Id == searchID).IncreaseSalary(percentage);

            // Exibir informações dos funcionários
            Console.WriteLine("\nUpdated list of employees");

            foreach(Employeer currentEmployeer in employees)
            {
                currentEmployeer.DisplayInfo();
            }
        }
    }
}
