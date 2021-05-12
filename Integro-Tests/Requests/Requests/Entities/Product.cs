namespace Requests.Entities
{
    class Product
    {
        // Informações do produto
        public string Name { get; set; }
        public float Price { get; set; }

        public Product()
        {

        }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
