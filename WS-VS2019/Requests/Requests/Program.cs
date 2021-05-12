using System;
using Requests.Entities;

namespace Requests
{
    class Requests
    {
        static void Main(string[] args)
        {
            // Dados do client
            Console.WriteLine("##### Enter client data #####");

            // Nome
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            // Email
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            
            // Aniversário
            Console.Write("Birth Data (DD/MM/YYYY): ");
            string clientBirthDate = Console.ReadLine();

            // Instanciar novo cliente
            Client client = new Client(clientName, clientEmail, clientBirthDate);

            // Dados do pedido            
            Console.WriteLine("\n##### Enter order data #####");

            // Instanciar pedido
            Order order = new Order(DateTime.Now, Entities.Enums.OrderStatus.Processing, client);

            Console.WriteLine($"Status: {order.States}");

            Console.Write("How many items to this order? ");
            int amountOfItems = int.Parse(Console.ReadLine());

            // Adicionar cada item ao pedido
            for(int i = 1; i <= amountOfItems; i++)
            {
                // Índice do produto
                Console.WriteLine($"\nEnter #{i} item data");

                // Nome do produto
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                // Preço do produto
                Console.Write("Product price: ");
                float productPrice = float.Parse(Console.ReadLine());

                // Quantidade do produto
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                // Adicionar item ao pedido
                order.AddItem(new OrderItem(productName, productQuantity, productPrice));
            }

            Console.WriteLine("\n##### ORDER SUMARRY #####");
            Console.WriteLine(order.ToString());
        }        
    }
}
