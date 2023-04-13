

using System.Drawing;

namespace Tic_Tac_Toe
{

    public class Board
    {  // un tableau ne peut pas changer de tailles. Il faut le mettre Constant
        public const int lenght = 11;
        public const int hight = 11;
        public ConsoleColor color= ConsoleColor.DarkGray;
        public char[,] Tableau = new char[lenght, hight];

        public void instanciateBoard()
        {
            for(int l = 0; l < lenght; l++)
            {
                for(int c = 0; c < hight; c++)
                {
                    if (
                           ((l == 3) && (c == 3))
                        || ((l == 3) && (c == 7))
                        || ((l == 7) && (c == 7))
                        || ((l == 7) && (c == 3))
                                                )
                    {
                        Tableau[l, c] = (char)'+';
                    }
                    else if (((l == 3) || (l == 7)) && ((c != 3) || (c != 7)))
                    {
                        Tableau[l, c] = (char)'-';
                    }
                    else if (((c == 3) || (c == 7)) && ((l != 3) || (l != 7)))
                    {
                        Tableau[l, c] = (char)'|';
                    }
                    else if (l == 1 && (c == 1))
                    {
                        Tableau[l,c] = (char)'1';
                    } else if (l ==1 && c == 5)
                    {
                        Tableau[l, c] = (char)'2';
                    }
                    else if (l == 1 && c == 9)
                    {
                        Tableau[l, c] = (char)'3';
                    }
                    else if (l == 5 && c == 1)
                    {
                        Tableau[l, c] = (char)'4';
                    }
                    else if (l == 5 && c == 5)
                    {
                        Tableau[l, c] = (char)'5';
                    }
                    else if (l == 5 && c == 9)
                    {
                        Tableau[l, c] = (char)'6';
                    }
                    else if (l == 9 && c == 1)
                    {
                        Tableau[l, c] = (char)'7';
                    }
                    else if (l == 9 && c == 5)
                    {
                        Tableau[l, c] = (char)'8';
                    }
                    else if (l == 9 && c == 9)
                    {
                        Tableau[l, c] = (char)'9';
                    }
                    else
                    {
                        Tableau[l, c] = (char)' ';
                    }
                }
            }
        }
        public void PrintBoard()
        {
            for(int i = 0; i < Tableau.GetLength(0); i++)
            {
                for(int j = 0; j < Tableau.GetLength(1); j++)
                {
                    if (Tableau[i, j] == 'O') {
                        Console.ForegroundColor = Player1.Color;
                        //Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Tableau[i, j] + " ");
                        Console.ResetColor();
                    }
                    else if (Tableau[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Tableau[i, j] + " ");
                        Console.ResetColor();
                    }
                    else { 

                    Console.ForegroundColor = color;
                    Console.Write(Tableau[i, j]+" ");
                    Console.ResetColor();
                        }
                }
                Console.WriteLine();
            }
        }
    }

    public class Player1
    {
        Board boardRef;
        public string name = "Joueur 1";
        public char symbole = 'O';
        public int conteurJoueur = 0;
        internal static ConsoleColor Color = ConsoleColor.Green;

        // MISE EN PLACE DE MON CONSTRUCTEUR AVEC REFERENCE A MON BOARD. ils vont se sincroniser 
        public Player1(Board existing_board)
        {
            boardRef = existing_board;
        }
      

        // methode message perte de tour case deja occupee :
        public void impressionMessageErreur()
        {
            Console.WriteLine("Cette case est deja occupee! choisissez une autre case!");
        }
        // methode pour le tour du joueur : 
        public void tourJoueur()
        {
            Console.WriteLine("C'est le Tour Du Joueur !");
            bool TourEnCours = true;
            
            while (TourEnCours)
            {
            
                Console.WriteLine("Sur quelle case voulez-vous poser votre symbole? ");
                int caseDeJeux = Convert.ToInt32(Console.ReadLine());
                
                switch (caseDeJeux)
                {
                    case 1:
                        if (boardRef.Tableau[1, 1] == '1')
                        {
                            boardRef.Tableau[1, 1] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;
                        }
                        else { impressionMessageErreur(); }
                        break;

                    case 2:
                        if (boardRef.Tableau[1, 5] == '2')
                        {
                            boardRef.Tableau[1, 5] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;
                    case 3:
                        if (boardRef.Tableau[1, 9] == '3')
                        {
                            boardRef.Tableau[1, 9] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;

                    case 4:
                        if (boardRef.Tableau[5, 1] == '4')
                        {
                            boardRef.Tableau[5, 1] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;
                    
                    case 5:
                        if (boardRef.Tableau[5, 5] == '5')
                        {
                            boardRef.Tableau[5, 5] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;
                    
                    case 6:
                        if (boardRef.Tableau[5, 9] == '6')
                        {
                            boardRef.Tableau[5, 9] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;
                    
                    case 7:
                        if (boardRef.Tableau[9, 1] == '7')
                        {
                            boardRef.Tableau[9, 1] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;
                    case 8:
                        if (boardRef.Tableau[9, 5] == '8')
                        {
                            boardRef.Tableau[9, 5] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;
                    case 9:
                        if (boardRef.Tableau[9, 9] == '9')
                        {
                            boardRef.Tableau[9, 9] = symbole;
                            TourEnCours = false;
                            conteurJoueur++;

                        }
                        else { impressionMessageErreur(); }
                        break;
                }
            }
            
        }
    }

    public class CPU 
    {
        Random rand = new Random();
        Board boardRef;
        public string name = "PC Ordinateur";
        public char symbole = 'X';
        public int conteurPC = 0;


        public CPU(Board existing_board)
        {
            boardRef = existing_board;
        }

        public void tourPC()
        {
            Console.WriteLine("C'est le Tour de l'ordinateur !");
            bool TourEnCours = true;
            
            while (TourEnCours)
            {
                int x = rand.Next(10);
                switch (x)
                {
                    case 1:
                        if (boardRef.Tableau[1, 1] == '1')
                        {
                            boardRef.Tableau[1, 1] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                        break;
                    
                    case 2:
                        if (boardRef.Tableau[1, 5] == '2')
                        {
                            boardRef.Tableau[1, 5] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                        
                        break;
                    case 3:
                        if (boardRef.Tableau[1, 9] == '3')
                        {
                            boardRef.Tableau[1, 9] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                      
                        break;
                    case 4:
                        if (boardRef.Tableau[5, 1] == '4')
                        {
                            boardRef.Tableau[5, 1] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                       
                        break;
                    case 5:
                        if (boardRef.Tableau[5, 5] == '5')
                        {
                            boardRef.Tableau[5, 5] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                       
                        break;
                    case 6:
                        if (boardRef.Tableau[5, 9] == '6')
                        {
                            boardRef.Tableau[5, 9] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                        
                        break;
                    case 7:
                        if (boardRef.Tableau[9, 1] == '7')
                        {
                            boardRef.Tableau[9, 1] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                        
                        break;
                    case 8:
                        if (boardRef.Tableau[9, 5] == '8')
                        {
                            boardRef.Tableau[9, 5] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                        break;
                    case 9:
                        if (boardRef.Tableau[1, 1] == '9')
                        {
                            boardRef.Tableau[9, 9] = symbole;
                            TourEnCours = false;
                            conteurPC++;
                        }
                        break;
                }
            }
        }

    }

    public class Game
    { // mise en place de ma classe Game ( partie en cours )
       public bool isrunning = true;
        Board boardRef;
        Player1 playerRef;
        CPU cpuRef;
        public string message = "hello world!";

        public Game(Board existing_board, Player1 existing_player1, CPU existing_cpu)
        {
            boardRef = existing_board;
            playerRef = existing_player1;
            cpuRef = existing_cpu; 
        }
        
        public void endOfGameCheck() // mise en place des conditions du jeux et verifications de la partie ( victoire PC/Joueur ou partie Nulle)
        {
            if ( // victoire JOUEUR1    
                ((boardRef.Tableau[1, 1] == 'O') && (boardRef.Tableau[1, 5] == 'O') && (boardRef.Tableau[1, 9] == 'O'))
             || ((boardRef.Tableau[5, 1] == 'O') && (boardRef.Tableau[5, 5] == 'O') && (boardRef.Tableau[5, 9] == 'O'))
             || ((boardRef.Tableau[9, 1] == 'O') && (boardRef.Tableau[9, 5] == 'O') && (boardRef.Tableau[9, 9] == 'O'))
             || ((boardRef.Tableau[1, 1] == 'O') && (boardRef.Tableau[5, 1] == 'O') && (boardRef.Tableau[9, 1] == 'O'))
             || ((boardRef.Tableau[1, 5] == 'O') && (boardRef.Tableau[5, 5] == 'O') && (boardRef.Tableau[9, 5] == 'O'))
             || ((boardRef.Tableau[1, 9] == 'O') && (boardRef.Tableau[5, 9] == 'O') && (boardRef.Tableau[9, 9] == 'O'))
             || ((boardRef.Tableau[1, 1] == 'O') && (boardRef.Tableau[5, 5] == 'O') && (boardRef.Tableau[9, 9] == 'O'))
             || ((boardRef.Tableau[9, 1] == 'O') && (boardRef.Tableau[5, 5] == 'O') && (boardRef.Tableau[1, 9] == 'O')))
            {
                isrunning = false;
                message = "Felicitations, Joueur 1 a Gagné!";          
            }
             else if ( // victoire PC1
                ((boardRef.Tableau[1, 1] == 'X') && (boardRef.Tableau[1, 5] == 'X') && (boardRef.Tableau[1, 9] == 'X'))
             || ((boardRef.Tableau[5, 1] == 'X') && (boardRef.Tableau[5, 5] == 'X') && (boardRef.Tableau[5, 9] == 'X'))
             || ((boardRef.Tableau[9, 1] == 'X') && (boardRef.Tableau[9, 5] == 'X') && (boardRef.Tableau[9, 9] == 'X'))
             || ((boardRef.Tableau[1, 1] == 'X') && (boardRef.Tableau[5, 1] == 'X') && (boardRef.Tableau[9, 1] == 'X'))
             || ((boardRef.Tableau[1, 5] == 'X') && (boardRef.Tableau[5, 5] == 'X') && (boardRef.Tableau[9, 5] == 'X'))
             || ((boardRef.Tableau[1, 9] == 'X') && (boardRef.Tableau[5, 9] == 'X') && (boardRef.Tableau[9, 9] == 'X'))
             || ((boardRef.Tableau[1, 1] == 'X') && (boardRef.Tableau[5, 5] == 'X') && (boardRef.Tableau[9, 9] == 'X'))
             || ((boardRef.Tableau[9, 1] == 'X') && (boardRef.Tableau[5, 5] == 'X') && (boardRef.Tableau[1, 9] == 'X')))
            {
                {
                    message = "Defaite! Le PC 1 a Gagné!";
                    isrunning = false;
                }
            } // Partie Nulle 
            else if ((cpuRef.conteurPC == 4)&&(playerRef.conteurJoueur == 5))
            {
                message = "C'est une partie Nulle! ";
                isrunning = false;
            }
        }
    }
}
