using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProgram.Entities.Exceptions;

namespace MainProgram.Entities
{
    class BankAccount
    {
        // Informações da conta bancária
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public float Balance { get; private set; }
        public float WithdrawLimit { get; private set; }

        // Método construtor #1
        public BankAccount()
        {

        }

        // Método construtor #2
        public BankAccount(int number, string holder, float balance, float withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // Depósito
        public void Deposit(float amount)
        { Balance += amount; }

        // Saque
        public void Withdraw(float amount)
        {
            // Lançar exceção
            if(amount > Balance)
            {
                throw new InsufficientBalanceException("Valor de saque maior do que o valor de saldo.");
            }

            if(amount > WithdrawLimit)
            {
                throw new WithdrawLimitException("Valor de saque maior do que o limite de saque pemitido");
            }

            // Sacar
            Balance -= amount;
        }
    }
}
