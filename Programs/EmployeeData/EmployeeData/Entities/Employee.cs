namespace Entities
{
    class Employee
    {
        // Informações do usuário
        public string Name { get; private set; }
        public string Email { get; private set; }
        public float Salary { get; private set; }

        public Employee(string name, string email, float salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
