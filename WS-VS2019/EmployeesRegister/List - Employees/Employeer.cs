using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmployees
{
    class Employeer
    {
        // Informações
        public int Id { get; private set; }
        public string Name { get; private set; }
        public float Salary { get; private set; }

        // Método construtor
        public Employeer(int id, string name, float salary)
        {
            Id = id;
            Name = name;
            Salary = salary;           
        }

        public void IncreaseSalary(float percent)
        { Salary += (Salary * percent / 100f); }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
        }
    }
}
