namespace Requests.Entities
{
    class OrderItem
    {
        // Informações do item do pedido
        public int Quantity { get; set; }
        public float Price { get; set; }
        public Product Product { get; set; }

        // Método construtor
        public OrderItem(string name, int quantity, float price)
        {
            Quantity = quantity;
            Price = price;

            Product = new Product(name, price);
        }

        public float Subtotal()
        { return Quantity * Price; }
    }
}
