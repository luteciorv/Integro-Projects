using System;
using ChessBoard;

namespace ChessConsole
{
    class Screen
    {
        public static void DisplayBoard(Board board)
        {
            // Pular 2 linhas
            Console.WriteLine("\n###### CHESS CONSOLE ######\n");

            // Percorrer as linhas do tabuleiro
            for(int row = 0; row < board.Rows; row++)
            {
                // Exibir a linha
                Console.Write($"  {8 - row}   ");

                // Percorrer as colunas do tabuleiro
                for(int column = 0; column < board.Columns; column++)
                {
                    // Caso nenhuma peça tenha sido encontrada
                    if (board.GetPiece(row, column) == null)
                    {
                        Console.Write("- ");
                    }

                    // Caso alguma peça tenha sido encontrada
                    else
                    {
                        DisplayPiece(board.GetPiece(row, column));

                        Console.Write(" ");
                    }                                       
                }

                // Pular uma linha
                Console.WriteLine("");
            }

            // Exibir a linha
            Console.WriteLine("\n      A B C D E F G H");
        }

        public static void DisplayPiece(Piece piece)
        {
            // Cor atual do console
            ConsoleColor normalColor = Console.ForegroundColor;

            // Cor a ser usada
            Console.ForegroundColor = ConsoleColor.White;

            switch (piece.Color)
            {
                // Amarelo
                case (Color.Yellow):                    
                    Console.ForegroundColor = ConsoleColor.Yellow;                                        
                    break;

                // Nenhuma peça encontrada
                default:
                    break;
            }
            
            // Exibir a peça
            Console.Write(piece);

            // Voltar ao normal
            Console.ForegroundColor = normalColor;
        }
    }
}
