﻿namespace Board
{
    class Board
    {
        // Informações do tabuleiro
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        // Método construtor
        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }
    }
}
