﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard.Board
{
    class Position
    {
        // Posições
        public int Row { get; set; }
        public int Column { get; set; }

        // Método construtor
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        // Sobrescrever => ToString
        public override string ToString()
        {
            return $"({Row}, {Column})";
        }

    }
}
