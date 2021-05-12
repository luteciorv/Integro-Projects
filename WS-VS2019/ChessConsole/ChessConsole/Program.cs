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

                board.PutPiece(new Tower(board, Color.Yellow), new Position(0, 0));
                board.PutPiece(new Tower(board, Color.Yellow), new Position(2, 5));
                board.PutPiece(new King(board, Color.White), new Position(3, 0));
                board.PutPiece(new King(board, Color.White), new Position(3, 7));


                Screen.DisplayBoard(board);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
