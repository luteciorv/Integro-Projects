using System;
using System.Text;
using System.Globalization;

namespace ProductsRegister.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, float price, string manufactureDate) : base(name, price)
        {
            ManufactureDate = DateTime.ParseExact(manufactureDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public override string PriceTag()
        {
            // Instanciar 
            StringBuilder sb = new StringBuilder();

            // Adicionar informações do produto no sb
            sb.AppendLine($"{base.PriceTag()} (Manufacture date: {ManufactureDate:dd/MM/yyyy})");

            // Substituir o nome do produto pelo Nome do produto + used
            sb.Replace(Name, $"{Name} (used)");

            return sb.ToString();
        }
    }
}
