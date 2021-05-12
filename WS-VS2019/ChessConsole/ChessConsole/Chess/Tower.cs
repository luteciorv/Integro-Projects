using ChessBoard;

namespace Chess
{
    class Tower : Piece
    {
        // Método construtor
        public Tower(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
