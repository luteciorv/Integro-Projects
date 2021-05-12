using System;
using System.Collections.Generic;
using Requests.Entities.Enums;
using System.Text;

namespace Requests.Entities
{
    class Order
    {
        // Informações do pedido
        public DateTime Moment { get; set; }
        public OrderStatus States { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItems = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus states, Client client)
        {
            Moment = moment;
            States = states;
            Client = client;
        }

        // Adicionar um item ao pedido
        public void AddItem(OrderItem item) 
        { OrderItems.Add(item); }

        // Remover um item do pedido
        public void RemoveItem(OrderItem item)
        { OrderItems.Remove(item); }

        // Valor total do pedido
        public float Total()
        {
            float total = 0f;

            foreach(OrderItem item in OrderItems) 
            { total += item.Subtotal(); }

            return total;
        }

        public override string ToString()
        {
            // Instanciar o String Builder
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Order moment: {Moment:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine($"Order status: {States}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate:dd/MM/yyyy}) - {Client.Email}");
            
            sb.AppendLine("\nOrder Items:");

            // Valor total
            float totalPrice = 0f;

            // Percorrer cada item e exibir suas informações
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine($"- {item.Product.Name}, ${item.Price:F2)}, Quantity: {item.Quantity}, Subtotal: ${item.Subtotal():F2}");
                totalPrice += item.Subtotal();
            }

            sb.AppendLine($"Total priece: ${totalPrice:F2}");

            // Retornar frase
            return sb.ToString();
        }
    }
}
