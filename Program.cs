namespace Tic_Tac_Toe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // INSTANTIATION DE MES OBJETS
            Board board = new();
            Player1 player1 = new Player1(board);
            CPU CP1 = new CPU(board);
            Game game =new Game(board,player1,CP1);


            // main
            board.instanciateBoard();
            while (game.isrunning)
            {
                board.PrintBoard();
                player1.tourJoueur();
                board.PrintBoard();
                game.endOfGameCheck();
                if(game.isrunning == false) { break; }
                Console.Clear();
                board.PrintBoard();
                CP1.tourPC();
                board.PrintBoard();
                game.endOfGameCheck();
                if (game.isrunning == false) { break; }
                Console.Clear();
                
            }
            Console.Clear();
            Console.WriteLine(game.message);
            board.PrintBoard();
        }
    }
}