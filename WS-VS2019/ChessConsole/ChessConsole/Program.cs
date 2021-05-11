using System;
using ChessBoard;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PutPiece(new Tower(board, Color.Orange), new Position(0, 0));
            board.PutPiece(new King(board, Color.Black), new Position(2, 4));


            Screen.DisplayBoard(board);
        }
    }
}
