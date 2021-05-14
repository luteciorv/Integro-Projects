using System;
using System.Collections.Generic;
using Entities;
using System.IO;
using System.Linq;
using System.Globalization;

namespace SetProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### PRODUTOS #####");

            // Instanciar lista de produtos
            List<Products> products = new List<Products>();

            // Caminho do arquivo
            Console.Write("Enter full file path: ");
            string filePath = Console.ReadLine();

            try
            {
                using (FileStream fileStrem = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStrem))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            // Lê a linha e divide entre Nome e preço
                            string[] line = streamReader.ReadLine().Split(", ");

                            // Captar as informações
                            string name = line[0];
                            float price = float.Parse(line[1], CultureInfo.InvariantCulture);

                            // Instanciar novo produto
                            products.Add(new Products(name, price));
                        }                        
                    }
                }
            }            

            catch(Exception e)
            {
                throw new Exception("Erro! " + e.Message);
            }

            // Preço médio dos produtos
            var averagePrice = products.Average(p => p.Price);

            // Produtos em ordem decrescente
            var decreaseOrder = products.Where(p => p.Price < averagePrice).OrderByDescending(p => p.Name).Select(p => p.Name);

            // Exibir preço médio
            Console.WriteLine($"Average Price: {averagePrice:F2}"); 

            // Exibir
            foreach(var currentProduct in decreaseOrder)
            {
                Console.WriteLine(currentProduct);
            }
        }
    }
}
