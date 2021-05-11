using ChessBoard;

namespace ChessBoard
{
    class ChessPosition
    {
        // Informações das posições das peças no tabuleiro de xadrez
        public int Row { get; set; }
        public char Column { get; set; }

        public ChessPosition(char column, int row)
        {
            Row = row;
            Column = column;
        }

        // Converte a posição da matriz para a posição do tabuleiro de xadrez (Visual)
        public Position ConvertPosition()
        {
            return new Position(8 - Row, Column - 'A');
        }

        public override string ToString()
        {
            return $"{Column}{Row}";
        }
    }
}
