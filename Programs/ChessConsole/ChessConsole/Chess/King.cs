﻿using ChessBoard;

namespace Chess
{
    class King : Piece
    {
        // Método construtor
        public King(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
