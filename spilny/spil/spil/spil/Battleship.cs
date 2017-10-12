using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class Battleship
    {
        public string winnerstring = " ";
   

        public char[,] GameBoard1 { get; set; }

        public char[,] GameBoard2 { get; set; }
        public char[,] GameBoard3 { get; set; }
        public char[,] GameBoard4 { get; set; }
        public char[,] GameBoards { get; set; }

        public char[,] skydeBoards { get; set; }

        public Battleship()
        {
            int tur = 2;
            if(tur == 1){
                GameBoards = GameBoard1;
                skydeBoards = GameBoard3;
            }
            else if (tur == 2)
            {
                GameBoards = GameBoard2;
                skydeBoards = GameBoard4;
            }
            GameBoards = new char[10, 10] {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };
            skydeBoards = new char[10, 10] {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };
            GameBoard1 = new char[10, 10] {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };

            //vi laver Gameboard2
            GameBoard2 = new char[10, 10] {
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' } ,
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                

            };
            GameBoard3 = new char[10, 10] {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };
            GameBoard4 = new char[10, 10] {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };



        }
        

        //public string GetGameBoardView1()
        //{
        //    string resultat = "";
        //    resultat = resultat + "Y\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "10 *  " + GameBoard1[0, 9] + "  *  " + GameBoard1[1, 9] + "  *  " + GameBoard1[2, 9] + "  *  " + GameBoard1[3, 9] + "  *  " + GameBoard1[4, 9] + "  *  " + GameBoard1[5, 9] + "  *  " + GameBoard1[6, 9] + "  *  " + GameBoard1[7, 9] + "  *  " + GameBoard1[8, 9] + "  *  " + GameBoard1[9, 9] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "9 *  " + GameBoard1[0, 8] + "  *  " + GameBoard1[1, 8] + "  *  " + GameBoard1[2, 8] + "  *  " + GameBoard1[3, 8] + "  *  " + GameBoard1[4, 8] + "  *  " + GameBoard1[5, 8] + "  *  " + GameBoard1[6, 8] + "  *  " + GameBoard1[7, 8] + "  *  " + GameBoard1[8, 8] + "  *  " + GameBoard1[9, 8] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "8 *  " + GameBoard1[0, 7] + "  *  " + GameBoard1[1, 7] + "  *  " + GameBoard1[2, 7] + "  *  " + GameBoard1[3, 7] + "  *  " + GameBoard1[4, 7] + "  *  " + GameBoard1[5, 7] + "  *  " + GameBoard1[6, 7] + "  *  " + GameBoard1[7, 7] + "  *  " + GameBoard1[8, 7] + "  *  " + GameBoard1[9, 7] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "7 *  " + GameBoard1[0, 6] + "  *  " + GameBoard1[1, 6] + "  *  " + GameBoard1[2, 6] + "  *  " + GameBoard1[3, 6] + "  *  " + GameBoard1[4, 6] + "  *  " + GameBoard1[5, 6] + "  *  " + GameBoard1[6, 6] + "  *  " + GameBoard1[7, 6] + "  *  " + GameBoard1[8, 6] + "  *  " + GameBoard1[9, 6] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "6 *  " + GameBoard1[0, 5] + "  *  " + GameBoard1[1, 5] + "  *  " + GameBoard1[2, 5] + "  *  " + GameBoard1[3, 5] + "  *  " + GameBoard1[4, 5] + "  *  " + GameBoard1[5, 5] + "  *  " + GameBoard1[6, 5] + "  *  " + GameBoard1[7, 5] + "  *  " + GameBoard1[8, 5] + "  *  " + GameBoard1[9, 5] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "5 *  " + GameBoard1[0, 4] + "  *  " + GameBoard1[1, 4] + "  *  " + GameBoard1[2, 4] + "  *  " + GameBoard1[3, 4] + "  *  " + GameBoard1[4, 4] + "  *  " + GameBoard1[5, 4] + "  *  " + GameBoard1[6, 4] + "  *  " + GameBoard1[7, 4] + "  *  " + GameBoard1[8, 4] + "  *  " + GameBoard1[9, 4] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "4 *  " + GameBoard1[0, 3] + "  *  " + GameBoard1[1, 3] + "  *  " + GameBoard1[2, 3] + "  *  " + GameBoard1[3, 3] + "  *  " + GameBoard1[4, 3] + "  *  " + GameBoard1[5, 3] + "  *  " + GameBoard1[6, 3] + "  *  " + GameBoard1[7, 3] + "  *  " + GameBoard1[8, 3] + "  *  " + GameBoard1[9, 3] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "3 *  " + GameBoard1[0, 2] + "  *  " + GameBoard1[1, 2] + "  *  " + GameBoard1[2, 2] + "  *  " + GameBoard1[3, 2] + "  *  " + GameBoard1[4, 2] + "  *  " + GameBoard1[5, 2] + "  *  " + GameBoard1[6, 2] + "  *  " + GameBoard1[7, 2] + "  *  " + GameBoard1[8, 2] + "  *  " + GameBoard1[9, 2] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "2 *  " + GameBoard1[0, 1] + "  *  " + GameBoard1[1, 1] + "  *  " + GameBoard1[2, 1] + "  *  " + GameBoard1[3, 1] + "  *  " + GameBoard1[4, 1] + "  *  " + GameBoard1[5, 1] + "  *  " + GameBoard1[6, 1] + "  *  " + GameBoard1[7, 1] + "  *  " + GameBoard1[8, 1] + "  *  " + GameBoard1[9, 1] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "1 *  " + GameBoard1[0, 0] + "  *  " + GameBoard1[1, 0] + "  *  " + GameBoard1[2, 0] + "  *  " + GameBoard1[3, 0] + "  *  " + GameBoard1[4, 0] + "  *  " + GameBoard1[5, 0] + "  *  " + GameBoard1[6, 0] + "  *  " + GameBoard1[7, 0] + "  *  " + GameBoard1[8, 0] + "  *  " + GameBoard1[9, 0] + "  *  " + "  *\n";
        //    resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
        //    resultat = resultat + "  *************************************************************\n";
        //    resultat = resultat + "     1     2     3     4     5     6     7     8     9    10    X\n";

        //    return resultat;

        //}


        public string GetGameBoardView2()
        {
            
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "10 *  " + GameBoards[0, 9] + "  *  " + GameBoards[1, 9] + "  *  " + GameBoards[2, 9] + "  *  " + GameBoards[3, 9] + "  *  " + GameBoards[4, 9] + "  *  " + GameBoards[5, 9] + "  *  " + GameBoards[6, 9] + "  *  " + GameBoards[7, 9] + "  *  " + GameBoards[8, 9] + "  *  " + GameBoards[9, 9] + "  *  " + " \n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoards[0, 8] + "  *  " + GameBoards[1, 8] + "  *  " + GameBoards[2, 8] + "  *  " + GameBoards[3, 8] + "  *  " + GameBoards[4, 8] + "  *  " + GameBoards[5, 8] + "  *  " + GameBoards[6, 8] + "  *  " + GameBoards[7, 8] + "  *  " + GameBoards[8, 8] + "  *  " + GameBoards[9, 8] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoards[0, 7] + "  *  " + GameBoards[1, 7] + "  *  " + GameBoards[2, 7] + "  *  " + GameBoards[3, 7] + "  *  " + GameBoards[4, 7] + "  *  " + GameBoards[5, 7] + "  *  " + GameBoards[6, 7] + "  *  " + GameBoards[7, 7] + "  *  " + GameBoards[8, 7] + "  *  " + GameBoards[9, 7] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoards[0, 6] + "  *  " + GameBoards[1, 6] + "  *  " + GameBoards[2, 6] + "  *  " + GameBoards[3, 6] + "  *  " + GameBoards[4, 6] + "  *  " + GameBoards[5, 6] + "  *  " + GameBoards[6, 6] + "  *  " + GameBoards[7, 6] + "  *  " + GameBoards[8, 6] + "  *  " + GameBoards[9, 6] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoards[0, 5] + "  *  " + GameBoards[1, 5] + "  *  " + GameBoards[2, 5] + "  *  " + GameBoards[3, 5] + "  *  " + GameBoards[4, 5] + "  *  " + GameBoards[5, 5] + "  *  " + GameBoards[6, 5] + "  *  " + GameBoards[7, 5] + "  *  " + GameBoards[8, 5] + "  *  " + GameBoards[9, 5] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoards[0, 4] + "  *  " + GameBoards[1, 4] + "  *  " + GameBoards[2, 4] + "  *  " + GameBoards[3, 4] + "  *  " + GameBoards[4, 4] + "  *  " + GameBoards[5, 4] + "  *  " + GameBoards[6, 4] + "  *  " + GameBoards[7, 4] + "  *  " + GameBoards[8, 4] + "  *  " + GameBoards[9, 4] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoards[0, 3] + "  *  " + GameBoards[1, 3] + "  *  " + GameBoards[2, 3] + "  *  " + GameBoards[3, 3] + "  *  " + GameBoards[4, 3] + "  *  " + GameBoards[5, 3] + "  *  " + GameBoards[6, 3] + "  *  " + GameBoards[7, 3] + "  *  " + GameBoards[8, 3] + "  *  " + GameBoards[9, 3] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoards[0, 2] + "  *  " + GameBoards[1, 2] + "  *  " + GameBoards[2, 2] + "  *  " + GameBoards[3, 2] + "  *  " + GameBoards[4, 2] + "  *  " + GameBoards[5, 2] + "  *  " + GameBoards[6, 2] + "  *  " + GameBoards[7, 2] + "  *  " + GameBoards[8, 2] + "  *  " + GameBoards[9, 2] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoards[0, 1] + "  *  " + GameBoards[1, 1] + "  *  " + GameBoards[2, 1] + "  *  " + GameBoards[3, 1] + "  *  " + GameBoards[4, 1] + "  *  " + GameBoards[5, 1] + "  *  " + GameBoards[6, 1] + "  *  " + GameBoards[7, 1] + "  *  " + GameBoards[8, 1] + "  *  " + GameBoards[9, 1] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoards[0, 0] + "  *  " + GameBoards[1, 0] + "  *  " + GameBoards[2, 0] + "  *  " + GameBoards[3, 0] + "  *  " + GameBoards[4, 0] + "  *  " + GameBoards[5, 0] + "  *  " + GameBoards[6, 0] + "  *  " + GameBoards[7, 0] + "  *  " + GameBoards[8, 0] + "  *  " + GameBoards[9, 0] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     1     2     3     4     5     6     7     8     9    10    X\n";
            
            return resultat;
        }

        public string Validate()
        {
            
            int checkaltx = 9;
            string skibenavne = "HSDUP";
            
            
            while (checkaltx >= 0)
            {
                
                for (int a = 0; a < 10; a++) { 
                int checkalty = a;
                    if (skibenavne.IndexOf(GameBoard2[checkaltx, checkalty]) > -1 /*&& GameBoard2[checkaltx, checkalty] != ' '*/)
                    {
                        winnerstring = "";
                        break;
                    }
                    else 
                    {
                        winnerstring = "Winner";
                        
                    }
            }
                    checkaltx--;
            }
            return winnerstring;
            


        }

        internal void Skydbrik(int x, int y, char tur)
        {
            
            if (tur == '1')
            {
                if(GameBoard2[x - 1,y - 1] == ' ')//GameBoard3 modspillers board
                {
                    GameBoard2[x - 1,y - 1] = 'o';//GameBoard2 sin egen skydeboard
                    Console.WriteLine("plask");
                }
                else if (GameBoard2[x - 1,y - 1] == 'x')//GameBoard2 sin egen skydeboard
                {
                    Console.WriteLine("Du har allerede ramt her");
                }
                else
                {
                    GameBoard2[x - 1,y - 1] = 'x';//GameBoard3 modspilleres board
                    Console.WriteLine("Ramt");
                }
            }
            if (tur == '2')
            {
                
                if (GameBoard2[x - 1,y - 1] == ' ')//GameBoard2 modspillers board
                {
                    GameBoard2[x - 1,y - 1] = 'o';//GameBoard4 sin egen skydeboard
                    Console.WriteLine("plask");
                }
                else if (GameBoard2[x - 1,y - 1] == 'x')//GameBoard4 sin egen skydeboard
                {
                    Console.WriteLine("Du har allerede ramt her");
                }
                else
                {
                    GameBoard2[x - 1,y - 1] = 'x';//GameBoard2 modspilleres board
                    Console.WriteLine("Ramt");
                }
            }
            
        }

        internal string SætSkib(int a, int b, int d, char c, string e)
        {
            

            string Success = "";
            bool Collision = false;

            
            string Rotation = e;
            int x = a;
            int y = b;
            //d = SLength || type
            //c = skibstype (D || H)

            

            //Lav en forløkke som tester for fejl

            

            //y = ja rotation, n = nej rotation
            if (Rotation == "n")
            {
                //sætter -1 ved d da løkken laver skibene et tak for langt.
                if (x <= 10 - d && y <= 10)
                {
                    for (int i = 0; i <= d - 1; i = i + 1)
                    {
                        if (GameBoard2[x + i - 1, y - 1] != ' ')
                        {
                            Collision = true;
                        }
                    }
                }

                if (x <= 10 - d && y <= 10 && !Collision)
                {
                    for (int i = 0; i <= d - 1; i = i + 1)
                    {
                        GameBoard2[x + i - 1, y - 1] = c;
                    }

                    Success = "Correct";
                }
                else
                {
                    Success = "Fejl";
                }
            }
            else
            {
                if (x <= 10 - d && y <= 10)
                {
                    for (int i = 0; i <= d - 1; i = i + 1)
                    {
                        if (GameBoard2[x - 1, y + i - 1] != ' ')
                        {
                            Collision = true;
                        }
                    }
                }

                if (x <= 10 - d && y <= 10 && !Collision)
                {
                    for (int i = 0; i <= d - 1; i = i + 1)
                    {
                        GameBoard2[x - 1, y + i - 1] = c;
                    }

                    Success = "Correct";
                }
                else
                {
                    Success = "Fejl";
                }

            }   

            return Success;

        }
    }

}
