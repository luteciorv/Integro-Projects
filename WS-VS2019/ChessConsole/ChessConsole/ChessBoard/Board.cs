using ChessBoard.Exceptions;

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

        // Retornar a peça na posição (Row, Column) #1
        public Piece GetPiece(int row, int column)
        { return Pieces[row, column]; }

        // Retornar a peça na posição (Row, Column) #2
        public Piece GetPiece(Position position) 
        { return Pieces[position.Row, position.Column]; }

        // Coloca uma peça em uma posição
        public void PutPiece(Piece piece, Position position)
        {
            if (HavePieceOnGavePosition(position))
            { throw new BoardException($"Erro! Já existe uma peça na posição ({position.Row}, {position.Column})"); }

            // Matriz de peças irá receber a nova peça na posição (Row, Column)
            Pieces[position.Row, position.Column] = piece;

            // Atribuir nova posição a peça
            piece.Position = position;
        }

        // Verifica se existe alguma peça na posição fornecida e, caso exista, retorna-la
        public bool HavePieceOnGavePosition(Position position) 
        {
            ValidatePosition(position);

            return GetPiece(position) != null; 
        }

        // Verificar se a posição informada é válida
        public bool ValidPosition(Position position)
        {
            return !(position.Row < 0 || position.Row >= Rows || position.Column < 0 || position.Column >= Columns);
        }

        public void ValidatePosition(Position position)
        {
            if(!ValidPosition(position))
            { throw new BoardException($"Erro! Posição ({position.Row}, {position.Column}) inválida."); }
        }
    }
}
