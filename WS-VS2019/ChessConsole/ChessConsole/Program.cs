using System;
using ChessBoard;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition position = new ChessPosition('C', 7);
            Console.WriteLine(position);

            Console.WriteLine(position.ConvertPosition());
        }
    }
}
