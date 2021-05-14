using System;

namespace MainProgram.Entities.Exceptions
{
    class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string message) : base(message)
        {
            
        }
    }
}
