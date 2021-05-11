using System;
using MainProgram.Entities;
using MainProgram.Entities.Exceptions;

namespace MainProgram
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            try
            {
                // Cadastro da conta
                Console.WriteLine("##### BANK ACCOUNT #####");

                // Informações da conta
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                float initialBalance = float.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                float withDrawLimit = float.Parse(Console.ReadLine());

                // Criar uma conta
                BankAccount bankAccount = new BankAccount(number, holder, initialBalance, withDrawLimit);

                // Quantidade para sacar
                Console.Write("\nEnter amount for withdraw: ");
                bankAccount.Withdraw(float.Parse(Console.ReadLine()));

                // Novo saldo
                Console.WriteLine($"New balance: {bankAccount.Balance:F2}");
            }

            catch (InsufficientBalanceException e)
            {
                Console.WriteLine($"Erro! {e.Message}");
            }

            catch(WithdrawLimitException e)
            {
                Console.WriteLine($"Erro!! {e.Message}");
            }
        }
    }
}
