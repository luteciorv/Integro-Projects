namespace ChessBoard
{
    class Piece
    {
        // Informações da peça de xadrez
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementsMade { get; protected set; }
        public Board Board { get; protected set; }

        // Método construtor
        public Piece(Board board, Color color)
        {
            Board = board;
            Color = color;

            Position = null;            
            MovementsMade = 0;
        }
    }
}
