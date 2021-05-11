namespace ChessBoard
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

        // Retornar uma peça
        public Piece GetPiece(int row, int column)
        { return Pieces[row, column]; }

        // Coloca uma peça em uma posição
        public void PutPiece(Piece piece, Position position)
        {
            // Matriz de peças irá receber a nova peça na posição (Row, Column)
            Pieces[position.Row, position.Column] = piece;

            // Atribuir nova posição a peça
            piece.Position = position;
        }
    }
}
