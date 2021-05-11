 namespace Board
{
    class Piece
    {
        // Informações da peça de xadrez
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementsMade { get; protected set; }
        public Board Board { get; protected set; }

        // Método construtor
        public Piece(Position position, Color color, Board board)
        {
            Position = position;
            Color = color;
            Board = board;
            MovementsMade = 0;
        }
    }
}
