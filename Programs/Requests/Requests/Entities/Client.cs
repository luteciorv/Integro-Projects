using System;
using System.Globalization;

namespace Requests.Entities
{
    class Client
    {
        // Informações do cliente
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, string birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
