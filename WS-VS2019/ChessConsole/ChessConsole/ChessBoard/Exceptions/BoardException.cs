using System;

namespace ChessBoard.Exceptions
{
    class BoardException : ApplicationException
    {
        public BoardException(string message) : base(message)
        {
        }
    }
}
