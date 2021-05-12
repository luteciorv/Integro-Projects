using System.Text;

namespace ProductsRegister.Entities
{
    class ImportedProduct : Product
    {
        // Taxa alfandegária
        public float CustomsFee { get; private set; }

        public ImportedProduct()
        {

        }

        // Método construtor + Herança
        public ImportedProduct(string name, float price, float customsFee) : base(name, price)
        {           
            CustomsFee = customsFee;
            Price += customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.PriceTag()} (Customs fee: $ {CustomsFee:F2})");
            
            return sb.ToString();
        }
    }
}
