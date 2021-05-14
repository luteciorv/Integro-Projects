using System;
using System.Collections.Generic;
using ProductsRegister.Entities;

namespace ProductsRegister
{
    class ProductsRegister
    {      
        static void Main(string[] args)
        {
            // Lista dos produtos
            List<Product> Products = new List<Product>();

            // Cadastro de produtos
            Console.WriteLine("##### Product Register #####");

            Console.Write("Enter the number of products: ");
            int amountOfProducts = int.Parse(Console.ReadLine());

            // Cadastrar cada produto
            for(int i = 1; i <= amountOfProducts; i++)
            {
                // Informações do produto #i
                Console.Write($"\nProduct #{i} data:");

                // Tipo de produto
                Console.Write("Common, Used or Imported (C/U/I)? ");
                char productType = char.ToLower(char.Parse(Console.ReadLine()));

                // Nome do produto
                Console.Write("Name: ");
                string productName = Console.ReadLine();

                // Preço do produto
                Console.Write("Price: ");
                float productPrice = float.Parse(Console.ReadLine());

                // Tipo comum
                if(productType == 'c')
                {
                    Products.Add(new Product(productName, productPrice));
                }

                // Tipo usado
                else if(productType == 'u')
                {
                    // Data de manufatura do produto
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    string manufactureDate = Console.ReadLine();

                    Products.Add(new UsedProduct(productName, productPrice, manufactureDate));
                }

                // Tipo importado
                else if(productType == 'i')
                {
                    // Data de manufatura do produto
                    Console.Write("Customs fee: ");
                    float customsFee = float.Parse(Console.ReadLine());

                    Products.Add(new ImportedProduct(productName, productPrice, customsFee));
                }
            }

            // Exibir os produtos
            Console.WriteLine("\n##### PRICE TAGS #####");

            foreach(Product currentProduct in Products)
            {
                Console.WriteLine(currentProduct.PriceTag());
            }
        }
    }
}
