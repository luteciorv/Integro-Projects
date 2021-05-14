using System;
using System.Collections.Generic;
using System.IO;

namespace FileAndFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caminho selecionado
            string path = @"C:\Users\luis\Documents\Luis F\Integro-Tests\FileAndFolder";

            // Pegar todos os arquivos no diretório passado que posusem a extensão ".csv"
            string[] files = Directory.GetFiles(path, "*.csv");

            Console.WriteLine("##### Arquivos no diretório atual #####\n");

            // Exibir cada arquivo
            for (int i = 1; i <= files.Length; i++)
            { Console.WriteLine($"Arquivo #{i} - {Path.GetFileName(files[i - 1])}"); }            

            // Instanciar um StreamWrite
            StreamWriter streamWriter;

            // Escolher um arquivo
            Console.Write("\nEscolha um arquivo: ");
            string filePath = files[int.Parse(Console.ReadLine()) - 1];

            try
            {
                // Ler todas as linhas do arquivo
                string[] lines = File.ReadAllLines(filePath);

                // Criar nova pasta
                Directory.CreateDirectory($@"{path}\out");                

                using (streamWriter = new StreamWriter(new FileStream($@"{path}\out\sumarry.csv", FileMode.OpenOrCreate)))
                {
                    // Acessar cada linha
                    foreach (string currentLine in lines)
                    {
                        // Separar a linha por ","
                        string[] lineSplitted = currentLine.Split(",");

                        // Valor total do produto (Valor * quantidade)
                        float totalValue = float.Parse(lineSplitted[1]) * float.Parse(lineSplitted[2]);

                        // Escrever no arquivo gerado
                        streamWriter.WriteLine($"{lineSplitted[0]}, {totalValue:F2}");
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"Erro! {e.Message}");
            }
        }
    }
}
