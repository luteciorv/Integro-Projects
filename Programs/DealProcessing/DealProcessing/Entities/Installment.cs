using System;
using System.Globalization;

namespace Entities
{
    class Installment
    {
        // Informações da pretação
        public DateTime DueDate { get; private set; }
        public float Amount { get; private set; }

        public Installment(DateTime dueDate, float amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        { return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture); }
    }
}
