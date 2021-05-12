namespace ProductsRegister.Entities
{
    class Product
    {
        // Informações do produto
        public string Name { get; private set; }
        public float Price { get; protected set; }

        // Método construtor #1
        public Product()
        {

        }

        // Método construtor #2
        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        // Exibição das informações do produto
        public virtual string PriceTag()
        {
            return $"- {Name} ${Price:F2}";
        }
    }
}
