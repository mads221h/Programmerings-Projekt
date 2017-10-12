using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe
    {
        public string winnerstring = "";
        public string spillerturcheck = "to";
        public int briktest = 0;
        public char[,] GameBoard { get; set; }

        public TicTacToe()
        {
            GameBoard = new char[3, 3] { {' ', ' ', ' '},
                {' ', ' ', ' '}, 
                { ' ', ' ', ' '} };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }

        

        




        internal string Sætbrik(string v, char b)
            
        {
            
            if (v == "1")
            {
                if (GameBoard[0, 0] == 'x' || GameBoard[0, 0] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[0, 0] = b;
                }

            }
            if (v == "2")
            {
                if (GameBoard[1, 0] == 'x' || GameBoard[1, 0] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[1, 0] = b;
                }
            }
            if (v == "3")
            {
                if (GameBoard[2, 0] == 'x' || GameBoard[2, 0] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[2, 0] = b;
                }
            }
            if (v == "4")
            {
                if (GameBoard[0, 1] == 'x' || GameBoard[0, 1] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[0,1] = b;
                }
            }
            if (v == "5")
            {
                if (GameBoard[1, 1] == 'x' || GameBoard[1,1] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[1, 1] = b;
                }
            }
            if (v == "6")
            {
                if (GameBoard[2,1] == 'x' || GameBoard[2,1] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[2,1] = b;
                }
            }
            if (v == "7")
            {
                if (GameBoard[0, 2] == 'x' || GameBoard[0,2] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[0,2] = b;
                }
            }
            if (v == "8")
            {
                if (GameBoard[1,2] == 'x' || GameBoard[1,2] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[1,2] = b;
                }
            }
            if (v == "9")
            {
                if (GameBoard[2, 2] == 'x' || GameBoard[2,2] == 'o')
                {
                    Console.WriteLine("Der er allerede en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[2, 2] = b;
                }
            }
            return spillerturcheck;
            
            }

        internal void sletbrik(string v, char tur)
        {
            if (v == "1")
            {
                if (GameBoard[0, 0] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else 
                {
                    GameBoard[0, 0] = ' ';
                }
                
                

            }
            if (v == "2")
            {
                if (GameBoard[1, 0] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else 
                {
                    GameBoard[1, 0] = ' ';
                }
                
            }
            if (v == "3")
            {
                if (GameBoard[2, 0] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[2, 0] = ' ';
                }
                
            }
            if (v == "4")
            {
                if (GameBoard[0, 1] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[0, 1] = ' ';
                }
                
            }
            if (v == "5")
            {
                if (GameBoard[1, 1] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[1, 1] = ' ';
                }
                
            }
            if (v == "6")
            {
                if (GameBoard[2, 1] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[2, 1] = ' ';
                }
                
            }
            if (v == "7")
            {
                if (GameBoard[0, 2] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else 
                {
                    GameBoard[0, 2] = ' ';
                }
                
            }
            if (v == "8")
            {
                if (GameBoard[1, 2] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else 
                {
                    GameBoard[1, 2] = ' ';
                }
                
            }
            if (v == "9")
            {
                if (GameBoard[2, 2] == ' ')
                {
                    Console.WriteLine("Der er ikke en brik der");
                    spillerturcheck = "forkert";
                    Console.ReadLine();
                }
                else
                {
                    GameBoard[2, 2] = ' ';
                }
                
            }
           

        }

        public string Validate()
        {
            
            string brikker = "ox";
            for (int i = 0; i < 3; i = i + 1)
            {
                
                var columnOneChar = GameBoard[i, 0];
                var columnTwoChar = GameBoard[i, 1];
                var columnThreeChar = GameBoard[i, 2];
                if (brikker.Contains(columnOneChar) && brikker.Contains(columnTwoChar) && brikker.Contains(columnThreeChar))
                {
                    if (columnOneChar == columnTwoChar && columnTwoChar == columnThreeChar)
                    {

                        Console.WriteLine( columnOneChar + " Wins");
                        winnerstring = "Winner";
                        Console.ReadLine();
                    }
                }
                var rowOneChar = GameBoard[0, i];
                var rowTwoChar = GameBoard[1, i];
                var rowThreeChar = GameBoard[2, i];
                if (brikker.Contains(rowOneChar) && brikker.Contains(rowTwoChar) && brikker.Contains(rowThreeChar))
                {
                    if (rowOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
                    {
                        Console.WriteLine(rowOneChar + " Wins");
                        winnerstring = "Winner";
                        Console.ReadLine();

                    }
                    
                }
                var cellOneChar = GameBoard[0, 0];
                var cellTwoChar = GameBoard[1, 1];
                var cellThreeChar = GameBoard[2, 2];
                if (brikker.Contains(cellOneChar) && brikker.Contains(cellTwoChar) && brikker.Contains(cellThreeChar))
                {
                    if (cellOneChar == cellTwoChar &&
                    cellTwoChar == cellThreeChar)
                    {
                        Console.WriteLine(cellOneChar + " Wins");
                        winnerstring = "Winner";
                        Console.ReadLine();

                    }
                }
                var celOneChar = GameBoard[2, 0];
                var celTwoChar = GameBoard[1, 1];
                var celThreeChar = GameBoard[0, 2];
                if (brikker.Contains(celOneChar) && brikker.Contains(celTwoChar) && brikker.Contains(celThreeChar))
                {
                    if (celOneChar == celTwoChar &&
                    celTwoChar == celThreeChar)
                    {
                        Console.WriteLine(celOneChar + " Wins");
                        winnerstring = "Winner";
                        Console.ReadLine();
                    }
                }
                
            }
           
            return winnerstring;

        }

    }
}
