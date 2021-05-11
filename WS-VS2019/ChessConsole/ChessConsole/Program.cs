using System;
using ChessBoard.Board;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.DisplayBoard(board);
        }
    }
}
