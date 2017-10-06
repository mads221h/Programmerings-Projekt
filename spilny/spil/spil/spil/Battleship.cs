﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class Battleship
    {
        public char[,] GameBoard2 { get; set; }

        public Battleship()
        {
            GameBoard2 = new char[10, 10] {
                {'H', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
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

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "10 *  " + GameBoard2[0, 9] + "  *  " + GameBoard2[1, 9] + "  *  " + GameBoard2[2, 9] + "  *  " + GameBoard2[3, 9] + "  *  " + GameBoard2[4, 9] + "  *  " + GameBoard2[5, 9] + "  *  " + GameBoard2[6, 9] + "  *  " + GameBoard2[7, 9] + "  *  " + GameBoard2[8, 9] + "  *  " + GameBoard2[9, 9] + "  *  " + " \n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoard2[0, 8] + "  *  " + GameBoard2[1, 8] + "  *  " + GameBoard2[2, 8] + "  *  " + GameBoard2[3, 8] + "  *  " + GameBoard2[4, 8] + "  *  " + GameBoard2[5, 8] + "  *  " + GameBoard2[6, 8] + "  *  " + GameBoard2[7, 8] + "  *  " + GameBoard2[8, 8] + "  *  " + GameBoard2[9, 8] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoard2[0, 7] + "  *  " + GameBoard2[1, 7] + "  *  " + GameBoard2[2, 7] + "  *  " + GameBoard2[3, 7] + "  *  " + GameBoard2[4, 7] + "  *  " + GameBoard2[5, 7] + "  *  " + GameBoard2[6, 7] + "  *  " + GameBoard2[7, 7] + "  *  " + GameBoard2[8, 7] + "  *  " + GameBoard2[9, 7] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoard2[0, 6] + "  *  " + GameBoard2[1, 6] + "  *  " + GameBoard2[2, 6] + "  *  " + GameBoard2[3, 6] + "  *  " + GameBoard2[4, 6] + "  *  " + GameBoard2[5, 6] + "  *  " + GameBoard2[6, 6] + "  *  " + GameBoard2[7, 6] + "  *  " + GameBoard2[8, 6] + "  *  " + GameBoard2[9, 6] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoard2[0, 5] + "  *  " + GameBoard2[1, 5] + "  *  " + GameBoard2[2, 5] + "  *  " + GameBoard2[3, 5] + "  *  " + GameBoard2[4, 5] + "  *  " + GameBoard2[5, 5] + "  *  " + GameBoard2[6, 5] + "  *  " + GameBoard2[7, 5] + "  *  " + GameBoard2[8, 5] + "  *  " + GameBoard2[9, 5] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoard2[0, 4] + "  *  " + GameBoard2[1, 4] + "  *  " + GameBoard2[2, 4] + "  *  " + GameBoard2[3, 4] + "  *  " + GameBoard2[4, 4] + "  *  " + GameBoard2[5, 4] + "  *  " + GameBoard2[6, 4] + "  *  " + GameBoard2[7, 4] + "  *  " + GameBoard2[8, 4] + "  *  " + GameBoard2[9, 4] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoard2[0, 3] + "  *  " + GameBoard2[1, 3] + "  *  " + GameBoard2[2, 3] + "  *  " + GameBoard2[3, 3] + "  *  " + GameBoard2[4, 3] + "  *  " + GameBoard2[5, 3] + "  *  " + GameBoard2[6, 3] + "  *  " + GameBoard2[7, 3] + "  *  " + GameBoard2[8, 3] + "  *  " + GameBoard2[9, 3] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard2[0, 2] + "  *  " + GameBoard2[1, 2] + "  *  " + GameBoard2[2, 2] + "  *  " + GameBoard2[3, 2] + "  *  " + GameBoard2[4, 2] + "  *  " + GameBoard2[5, 2] + "  *  " + GameBoard2[6, 2] + "  *  " + GameBoard2[7, 2] + "  *  " + GameBoard2[8, 2] + "  *  " + GameBoard2[9, 2] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard2[0, 1] + "  *  " + GameBoard2[1, 1] + "  *  " + GameBoard2[2, 1] + "  *  " + GameBoard2[3, 1] + "  *  " + GameBoard2[4, 1] + "  *  " + GameBoard2[5, 1] + "  *  " + GameBoard2[6, 1] + "  *  " + GameBoard2[7, 1] + "  *  " + GameBoard2[8, 1] + "  *  " + GameBoard2[9, 1] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard2[0, 0] + "  *  " + GameBoard2[1, 0] + "  *  " + GameBoard2[2, 0] + "  *  " + GameBoard2[3, 0] + "  *  " + GameBoard2[4, 0] + "  *  " + GameBoard2[5, 0] + "  *  " + GameBoard2[6, 0] + "  *  " + GameBoard2[7, 0] + "  *  " + GameBoard2[8, 0] + "  *  " + GameBoard2[9, 0] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "     1     2     3     4     5     6     7     8     9    10    X\n";

            return resultat;
        }

        internal void Validate()
        {
            int checkaltx = 9;
            string skibenavne = "HSDUP";
            while (checkaltx >= 0)
            {

                for (int a = 0; a > 10; a++) { 
                int checkalty = a;
                    if (skibenavne.Contains(GameBoard2[checkaltx, checkalty]))
                    {
                        Console.WriteLine("Spillet er igang");
                    }
                    else
                    {
                        Console.WriteLine("Spillet er slut");
                    }
            }
            }
            


        }

        internal void Skydbrik(int x, int y, char tur)
        {
            
            if (tur == '1')
            {
                if(GameBoard2[x,y] == ' ')//GameBoard3 modspillers board
                {
                    GameBoard2[x, y] = 'o';//GameBoard2 sin egen skydeboard
                    Console.WriteLine("plask");
                }
                if (GameBoard2[x, y] == 'x')//GameBoard2 sin egen skydeboard
                {
                    Console.WriteLine("Du har allerede ramt her");
                }
                else
                {
                    GameBoard2[x, y] = 'x';//GameBoard3 modspilleres board
                }
            }
            if (tur == '2')
            {
                if (GameBoard2[x, y] == ' ')//GameBoard2 modspillers board
                {
                    GameBoard2[x, y] = 'o';//GameBoard4 sin egen skydeboard
                    Console.WriteLine("plask");
                }
                if (GameBoard2[x, y] == 'x')//GameBoard4 sin egen skydeboard
                {
                    Console.WriteLine("Du har allerede ramt her");
                }
                else
                {
                    GameBoard2[x, y] = 'x';//GameBoard2 modspilleres board
                    Console.WriteLine("Ramt");
                }
            }
        }

        internal void SætSkib(int a, int b, int d, char c)
        {
            //Mangler:

            int x = a;
            int y = b;
            //d = SLength || type
            //c = skibstype (D || H)


            for (int i = 0; i <= d; i = i + 1)
            {
                GameBoard2[x + i - 1, y - 1] = c;
            }


        }
    }

}
