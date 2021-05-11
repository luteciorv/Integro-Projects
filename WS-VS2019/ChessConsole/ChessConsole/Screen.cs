using System;
using ChessBoard.Board;

namespace ChessConsole
{
    class Screen
    {
        public static void DisplayBoard(Board board)
        {
            // Percorrer as linhas do tabuleiro
            for(int row = 0; row < board.Rows; row++)
            {
                // Percorrer as colunas do tabuleiro
                for(int column = 0; column < board.Columns; column++)
                {
                    // Decidir o que exibir
                    string display = board.GetPiece(row, column) == null ? "- " : board.GetPiece(row, column) + " ";
                    
                    Console.Write(display);
                }

                // Pular uma linha
                Console.WriteLine("");
            }
        }
    }
}
