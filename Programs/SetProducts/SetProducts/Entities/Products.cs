using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Products
    {
        // Informações do produto
        public string Name { get; private set; }
        public float Price { get; private set; }

        // Construtor
        public Products(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price:F2}";
        }
    }
}
