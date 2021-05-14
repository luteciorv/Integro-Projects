using System;
using System.Collections.Generic;

namespace Entities
{
    class Contract
    {
        // Informações do contrato
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public float TotalValue { get; private set; }
        public List<Installment> Installments { get; private set; }

        public Contract(int number, DateTime date, float totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        { Installments.Add(installment); }
    }
}
