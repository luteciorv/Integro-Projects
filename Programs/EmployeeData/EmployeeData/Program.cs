using System;
using System.IO;
using Entities;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### DADOS DOS FUNCIONÁRIOS #####");

            // Criar lita de empregados
            List<Employee> employees = new List<Employee>();

            // Caminho do arquivo
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();

            try
            {
                // Ler os dados do arquivo
                using (StreamReader streamReader = File.OpenText(filePath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        // Pegar a linha atual do arquivo e divir pela ", "
                        string[] line = streamReader.ReadLine().Split(", ");

                        // Informações do empregado
                        string name = line[0];
                        string email = line[1];
                        float salary = float.Parse(line[2], CultureInfo.InvariantCulture);

                        // Instanciar novo funcionário
                        employees.Add(new Employee(name, email, salary));
                    }
                }
            }           
            
            catch(Exception e) 
            { throw new Exception($"Erro! {e.Message}"); }

            // Informar salário
            Console.Write("Enter salary: ");
            float salaryValue = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Pegar os funcionário com salário superior ao valor informado
            // E também organizar o email deles em ordem alfabética
            var emails = employees.Where(e => e.Salary > salaryValue).OrderBy(e => e.Email).Select(e => e.Email);

            // Salários dos funcionários que começam com a letra 'M'
            var salarySum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

            // Exibir emails
            Console.WriteLine($"\nEmail of people whose salary is more than {salaryValue}");

            foreach(string currentEmail in emails)
            {
                Console.WriteLine(currentEmail);
            }

            // Exibir soma dos salários dos funcionários que começam com a letra 'M'
            Console.WriteLine($"\nSum of salary of people whose name starts with 'M': {salarySum}");
        }
    }
}
