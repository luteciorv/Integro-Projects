using System;
using ChessBoard;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.PutPiece(new Tower(board, Color.Orange), new Position(0, 0));
                board.PutPiece(new King(board, Color.Black), new Position(-1, 0));


                Screen.DisplayBoard(board);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
