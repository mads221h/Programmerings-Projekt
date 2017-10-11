using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class Battleship
    {
        
   
        //Skibe sætning
        public char[,] GameBoard1 { get; set; }

        public char[,] GameBoard2 { get; set; }

        //Skydeboards
        public char[,] GameBoard3 { get; set; }

        public char[,] GameBoard4 { get; set; }
        
        //Hidden boards for ship sinking
        public char[,] GameBoardHidden1 { get; set; }

        public char[,] GameBoardHidden2 { get; set; }

        public Battleship()
        {

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

            GameBoardHidden1 = new char[10, 10] {
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

            GameBoardHidden2 = new char[10, 10] {
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
        

        public string GetGameBoardView1()
        {
           

                string resultat = "";
                resultat = resultat + "Y\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "10*  " + GameBoard1[0, 9] + "  *  " + GameBoard1[1, 9] + "  *  " + GameBoard1[2, 9] + "  *  " + GameBoard1[3, 9] + "  *  " + GameBoard1[4, 9] + "  *  " + GameBoard1[5, 9] + "  *  " + GameBoard1[6, 9] + "  *  " + GameBoard1[7, 9] + "  *  " + GameBoard1[8, 9] + "  *  " + GameBoard1[9, 9] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "9 *  " + GameBoard1[0, 8] + "  *  " + GameBoard1[1, 8] + "  *  " + GameBoard1[2, 8] + "  *  " + GameBoard1[3, 8] + "  *  " + GameBoard1[4, 8] + "  *  " + GameBoard1[5, 8] + "  *  " + GameBoard1[6, 8] + "  *  " + GameBoard1[7, 8] + "  *  " + GameBoard1[8, 8] + "  *  " + GameBoard1[9, 8] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "8 *  " + GameBoard1[0, 7] + "  *  " + GameBoard1[1, 7] + "  *  " + GameBoard1[2, 7] + "  *  " + GameBoard1[3, 7] + "  *  " + GameBoard1[4, 7] + "  *  " + GameBoard1[5, 7] + "  *  " + GameBoard1[6, 7] + "  *  " + GameBoard1[7, 7] + "  *  " + GameBoard1[8, 7] + "  *  " + GameBoard1[9, 7] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "7 *  " + GameBoard1[0, 6] + "  *  " + GameBoard1[1, 6] + "  *  " + GameBoard1[2, 6] + "  *  " + GameBoard1[3, 6] + "  *  " + GameBoard1[4, 6] + "  *  " + GameBoard1[5, 6] + "  *  " + GameBoard1[6, 6] + "  *  " + GameBoard1[7, 6] + "  *  " + GameBoard1[8, 6] + "  *  " + GameBoard1[9, 6] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "6 *  " + GameBoard1[0, 5] + "  *  " + GameBoard1[1, 5] + "  *  " + GameBoard1[2, 5] + "  *  " + GameBoard1[3, 5] + "  *  " + GameBoard1[4, 5] + "  *  " + GameBoard1[5, 5] + "  *  " + GameBoard1[6, 5] + "  *  " + GameBoard1[7, 5] + "  *  " + GameBoard1[8, 5] + "  *  " + GameBoard1[9, 5] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "5 *  " + GameBoard1[0, 4] + "  *  " + GameBoard1[1, 4] + "  *  " + GameBoard1[2, 4] + "  *  " + GameBoard1[3, 4] + "  *  " + GameBoard1[4, 4] + "  *  " + GameBoard1[5, 4] + "  *  " + GameBoard1[6, 4] + "  *  " + GameBoard1[7, 4] + "  *  " + GameBoard1[8, 4] + "  *  " + GameBoard1[9, 4] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "4 *  " + GameBoard1[0, 3] + "  *  " + GameBoard1[1, 3] + "  *  " + GameBoard1[2, 3] + "  *  " + GameBoard1[3, 3] + "  *  " + GameBoard1[4, 3] + "  *  " + GameBoard1[5, 3] + "  *  " + GameBoard1[6, 3] + "  *  " + GameBoard1[7, 3] + "  *  " + GameBoard1[8, 3] + "  *  " + GameBoard1[9, 3] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "3 *  " + GameBoard1[0, 2] + "  *  " + GameBoard1[1, 2] + "  *  " + GameBoard1[2, 2] + "  *  " + GameBoard1[3, 2] + "  *  " + GameBoard1[4, 2] + "  *  " + GameBoard1[5, 2] + "  *  " + GameBoard1[6, 2] + "  *  " + GameBoard1[7, 2] + "  *  " + GameBoard1[8, 2] + "  *  " + GameBoard1[9, 2] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "2 *  " + GameBoard1[0, 1] + "  *  " + GameBoard1[1, 1] + "  *  " + GameBoard1[2, 1] + "  *  " + GameBoard1[3, 1] + "  *  " + GameBoard1[4, 1] + "  *  " + GameBoard1[5, 1] + "  *  " + GameBoard1[6, 1] + "  *  " + GameBoard1[7, 1] + "  *  " + GameBoard1[8, 1] + "  *  " + GameBoard1[9, 1] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  *************************************************************\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "1 *  " + GameBoard1[0, 0] + "  *  " + GameBoard1[1, 0] + "  *  " + GameBoard1[2, 0] + "  *  " + GameBoard1[3, 0] + "  *  " + GameBoard1[4, 0] + "  *  " + GameBoard1[5, 0] + "  *  " + GameBoard1[6, 0] + "  *  " + GameBoard1[7, 0] + "  *  " + GameBoard1[8, 0] + "  *  " + GameBoard1[9, 0] + "  *  " + "  *\n";
                resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
                resultat = resultat + "  ******************(Spiller 1 skibsboard)*********************\n";
                resultat = resultat + "     1     2     3     4     5     6     7     8     9    10    X\n";
            
            return resultat;
        }


        public string GetGameBoardView2()
        {

            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "10*  " + GameBoard2[0, 9] + "  *  " + GameBoard2[1, 9] + "  *  " + GameBoard2[2, 9] + "  *  " + GameBoard2[3, 9] + "  *  " + GameBoard2[4, 9] + "  *  " + GameBoard2[5, 9] + "  *  " + GameBoard2[6, 9] + "  *  " + GameBoard2[7, 9] + "  *  " + GameBoard2[8, 9] + "  *  " + GameBoard2[9, 9] + "  *  " + " \n";
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
            resultat = resultat + "  ******************(Spiller 2 skibsboard)*********************\n";
            resultat = resultat + "     1     2     3     4     5     6     7     8     9    10    X\n";

            return resultat;
        }

        public string GetGameBoardView3()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "10*  " + GameBoard3[0, 9] + "  *  " + GameBoard3[1, 9] + "  *  " + GameBoard3[2, 9] + "  *  " + GameBoard3[3, 9] + "  *  " + GameBoard3[4, 9] + "  *  " + GameBoard3[5, 9] + "  *  " + GameBoard3[6, 9] + "  *  " + GameBoard3[7, 9] + "  *  " + GameBoard3[8, 9] + "  *  " + GameBoard3[9, 9] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoard3[0, 8] + "  *  " + GameBoard3[1, 8] + "  *  " + GameBoard3[2, 8] + "  *  " + GameBoard3[3, 8] + "  *  " + GameBoard3[4, 8] + "  *  " + GameBoard3[5, 8] + "  *  " + GameBoard3[6, 8] + "  *  " + GameBoard3[7, 8] + "  *  " + GameBoard3[8, 8] + "  *  " + GameBoard3[9, 8] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoard3[0, 7] + "  *  " + GameBoard3[1, 7] + "  *  " + GameBoard3[2, 7] + "  *  " + GameBoard3[3, 7] + "  *  " + GameBoard3[4, 7] + "  *  " + GameBoard3[5, 7] + "  *  " + GameBoard3[6, 7] + "  *  " + GameBoard3[7, 7] + "  *  " + GameBoard3[8, 7] + "  *  " + GameBoard3[9, 7] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoard3[0, 6] + "  *  " + GameBoard3[1, 6] + "  *  " + GameBoard3[2, 6] + "  *  " + GameBoard3[3, 6] + "  *  " + GameBoard3[4, 6] + "  *  " + GameBoard3[5, 6] + "  *  " + GameBoard3[6, 6] + "  *  " + GameBoard3[7, 6] + "  *  " + GameBoard3[8, 6] + "  *  " + GameBoard3[9, 6] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoard3[0, 5] + "  *  " + GameBoard3[1, 5] + "  *  " + GameBoard3[2, 5] + "  *  " + GameBoard3[3, 5] + "  *  " + GameBoard3[4, 5] + "  *  " + GameBoard3[5, 5] + "  *  " + GameBoard3[6, 5] + "  *  " + GameBoard3[7, 5] + "  *  " + GameBoard3[8, 5] + "  *  " + GameBoard3[9, 5] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoard3[0, 4] + "  *  " + GameBoard3[1, 4] + "  *  " + GameBoard3[2, 4] + "  *  " + GameBoard3[3, 4] + "  *  " + GameBoard3[4, 4] + "  *  " + GameBoard3[5, 4] + "  *  " + GameBoard3[6, 4] + "  *  " + GameBoard3[7, 4] + "  *  " + GameBoard3[8, 4] + "  *  " + GameBoard3[9, 4] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoard3[0, 3] + "  *  " + GameBoard3[1, 3] + "  *  " + GameBoard3[2, 3] + "  *  " + GameBoard3[3, 3] + "  *  " + GameBoard3[4, 3] + "  *  " + GameBoard3[5, 3] + "  *  " + GameBoard3[6, 3] + "  *  " + GameBoard3[7, 3] + "  *  " + GameBoard3[8, 3] + "  *  " + GameBoard3[9, 3] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard3[0, 2] + "  *  " + GameBoard3[1, 2] + "  *  " + GameBoard3[2, 2] + "  *  " + GameBoard3[3, 2] + "  *  " + GameBoard3[4, 2] + "  *  " + GameBoard3[5, 2] + "  *  " + GameBoard3[6, 2] + "  *  " + GameBoard3[7, 2] + "  *  " + GameBoard3[8, 2] + "  *  " + GameBoard3[9, 2] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard3[0, 1] + "  *  " + GameBoard3[1, 1] + "  *  " + GameBoard3[2, 1] + "  *  " + GameBoard3[3, 1] + "  *  " + GameBoard3[4, 1] + "  *  " + GameBoard3[5, 1] + "  *  " + GameBoard3[6, 1] + "  *  " + GameBoard3[7, 1] + "  *  " + GameBoard3[8, 1] + "  *  " + GameBoard3[9, 1] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard3[0, 0] + "  *  " + GameBoard3[1, 0] + "  *  " + GameBoard3[2, 0] + "  *  " + GameBoard3[3, 0] + "  *  " + GameBoard3[4, 0] + "  *  " + GameBoard3[5, 0] + "  *  " + GameBoard3[6, 0] + "  *  " + GameBoard3[7, 0] + "  *  " + GameBoard3[8, 0] + "  *  " + GameBoard3[9, 0] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  ******************(Spiller 1 skydeboard)*********************\n";
            resultat = resultat + "     1     2     3     4     5     6     7     8     9    10    X\n";

            return resultat;
        }

        public string GetGameBoardView4()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "10*  " + GameBoard4[0, 9] + "  *  " + GameBoard4[1, 9] + "  *  " + GameBoard4[2, 9] + "  *  " + GameBoard4[3, 9] + "  *  " + GameBoard4[4, 9] + "  *  " + GameBoard4[5, 9] + "  *  " + GameBoard4[6, 9] + "  *  " + GameBoard4[7, 9] + "  *  " + GameBoard4[8, 9] + "  *  " + GameBoard4[9, 9] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "9 *  " + GameBoard4[0, 8] + "  *  " + GameBoard4[1, 8] + "  *  " + GameBoard4[2, 8] + "  *  " + GameBoard4[3, 8] + "  *  " + GameBoard4[4, 8] + "  *  " + GameBoard4[5, 8] + "  *  " + GameBoard4[6, 8] + "  *  " + GameBoard4[7, 8] + "  *  " + GameBoard4[8, 8] + "  *  " + GameBoard4[9, 8] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "8 *  " + GameBoard4[0, 7] + "  *  " + GameBoard4[1, 7] + "  *  " + GameBoard4[2, 7] + "  *  " + GameBoard4[3, 7] + "  *  " + GameBoard4[4, 7] + "  *  " + GameBoard4[5, 7] + "  *  " + GameBoard4[6, 7] + "  *  " + GameBoard4[7, 7] + "  *  " + GameBoard4[8, 7] + "  *  " + GameBoard4[9, 7] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "7 *  " + GameBoard4[0, 6] + "  *  " + GameBoard4[1, 6] + "  *  " + GameBoard4[2, 6] + "  *  " + GameBoard4[3, 6] + "  *  " + GameBoard4[4, 6] + "  *  " + GameBoard4[5, 6] + "  *  " + GameBoard4[6, 6] + "  *  " + GameBoard4[7, 6] + "  *  " + GameBoard4[8, 6] + "  *  " + GameBoard4[9, 6] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "6 *  " + GameBoard4[0, 5] + "  *  " + GameBoard4[1, 5] + "  *  " + GameBoard4[2, 5] + "  *  " + GameBoard4[3, 5] + "  *  " + GameBoard4[4, 5] + "  *  " + GameBoard4[5, 5] + "  *  " + GameBoard4[6, 5] + "  *  " + GameBoard4[7, 5] + "  *  " + GameBoard4[8, 5] + "  *  " + GameBoard4[9, 5] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "5 *  " + GameBoard4[0, 4] + "  *  " + GameBoard4[1, 4] + "  *  " + GameBoard4[2, 4] + "  *  " + GameBoard4[3, 4] + "  *  " + GameBoard4[4, 4] + "  *  " + GameBoard4[5, 4] + "  *  " + GameBoard4[6, 4] + "  *  " + GameBoard4[7, 4] + "  *  " + GameBoard4[8, 4] + "  *  " + GameBoard4[9, 4] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "4 *  " + GameBoard4[0, 3] + "  *  " + GameBoard4[1, 3] + "  *  " + GameBoard4[2, 3] + "  *  " + GameBoard4[3, 3] + "  *  " + GameBoard4[4, 3] + "  *  " + GameBoard4[5, 3] + "  *  " + GameBoard4[6, 3] + "  *  " + GameBoard4[7, 3] + "  *  " + GameBoard4[8, 3] + "  *  " + GameBoard4[9, 3] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard4[0, 2] + "  *  " + GameBoard4[1, 2] + "  *  " + GameBoard4[2, 2] + "  *  " + GameBoard4[3, 2] + "  *  " + GameBoard4[4, 2] + "  *  " + GameBoard4[5, 2] + "  *  " + GameBoard4[6, 2] + "  *  " + GameBoard4[7, 2] + "  *  " + GameBoard4[8, 2] + "  *  " + GameBoard4[9, 2] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard4[0, 1] + "  *  " + GameBoard4[1, 1] + "  *  " + GameBoard4[2, 1] + "  *  " + GameBoard4[3, 1] + "  *  " + GameBoard4[4, 1] + "  *  " + GameBoard4[5, 1] + "  *  " + GameBoard4[6, 1] + "  *  " + GameBoard4[7, 1] + "  *  " + GameBoard4[8, 1] + "  *  " + GameBoard4[9, 1] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  *************************************************************\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard4[0, 0] + "  *  " + GameBoard4[1, 0] + "  *  " + GameBoard4[2, 0] + "  *  " + GameBoard4[3, 0] + "  *  " + GameBoard4[4, 0] + "  *  " + GameBoard4[5, 0] + "  *  " + GameBoard4[6, 0] + "  *  " + GameBoard4[7, 0] + "  *  " + GameBoard4[8, 0] + "  *  " + GameBoard4[9, 0] + "  *  " + "  *\n";
            resultat = resultat + "  *     *     *     *     *     *     *     *     *     *     *\n";
            resultat = resultat + "  ******************(Spiller 2 skydeboard)*********************\n";
            resultat = resultat + "     1     2     3     4     5     6     7     8     9    10    X\n";

            return resultat;
        }

        
        public string ValidateSunk()
        {
            //Vi mangler dette punkt
            string resultat = "";

            int checkaltx1 = 9;

            while (checkaltx1 >= 0)
            {

                for (int a = 0; a < 10; a++)
                {
                    int checkalty1 = a;


                    if (GameBoard1[checkaltx1, checkalty1] == '9')
                    {
                        resultat = "Sunket";
                    }
                    
                }
                checkaltx1--;
            }

            return resultat;
        }

        public string Validate()
        {


            bool SkibFundet1 = false;
            bool SkibFundet2 = false;

            string WinnerFound = "";
            string skibenavne = "HBDUP";

            int checkaltx1 = 9;
            int checkaltx2 = 9;


            //Board 1
            while (checkaltx1 >= 0)
            {

                for (int a = 0; a < 10; a++)
                {
                    int checkalty1 = a;

                    
                    if (skibenavne.IndexOf(GameBoard1[checkaltx1, checkalty1]) > 1)
                    {
                        SkibFundet1 = true;
                    }
                }
                checkaltx1--;
            }

            //Board 2
            while (checkaltx2 >= 0)
            {

                for (int a = 0; a < 10; a++)
                {
                    int checkalty2 = a;

                  
                    if (skibenavne.IndexOf(GameBoard2[checkaltx2, checkalty2]) > 1)
                    {
                        SkibFundet2 = true;
                    }
                }
                checkaltx2--;
            }

            if (!SkibFundet1 || !SkibFundet2)
            {
                WinnerFound = "Winner";
            }

            return WinnerFound;
        }


        internal void Skydbrik(int x, int y, char tur)
        {
            //Spiller 1 = gameboard 1 && 3
            //Spiller 2 = gameboard 2 && 4

            //Dette kunne man have brugt:
            //char[] skibe = { 'H', 'D', 'P', 'U', 'B' };
            // skibe.Contains(GameBoard2[x - 1, y - 1])
            


            if (tur == '1')
            {
                

                if (GameBoard2[x - 1,y - 1] == ' ')//GameBoard2 modspillers board
                {
                    GameBoard3[x - 1,y - 1] = 'o';//GameBoard1 sin egen skydeboard
                    GameBoard2[x - 1, y - 1] = 'o';
                    Console.WriteLine("plask");
                    Console.ReadLine();
                }
                else if (GameBoard3[x - 1, y - 1] == 'x')//GameBoard1 sin egen skydeboard
                {
                    Console.WriteLine("Du har allerede ramt her");
                    Console.ReadLine();
                }
                else
                {
                    GameBoard2[x - 1,y - 1] = 'x';//GameBoard2 modspilleres board
                    GameBoard3[x - 1, y - 1] = 'x';//sit eget skydeboard
                    Console.WriteLine("Ramt");
                    Console.ReadLine();
                }
            }

            if (tur == '2')
            {
                
                if (GameBoard1[x - 1,y - 1] == ' ')//GameBoard1 modspillers board
                {
                    GameBoard4[x - 1,y - 1] = 'o';//GameBoard2 sin egen skydeboard
                    GameBoard1[x - 1, y - 1] = 'o';//Modstanderens board
                    Console.WriteLine("plask");
                    Console.ReadLine();
                }
                else if (GameBoard4[x - 1,y - 1] == 'x')//GameBoard2 sin egen skydeboard
                {
                    Console.WriteLine("Du har allerede ramt her");
                    Console.ReadLine();

                }
                else
                {
                    GameBoard1[x - 1,y - 1] = 'x';//GameBoard1 modspilleres board
                    GameBoard4[x - 1, y - 1] = 'x';//Sit eget skydeboard
                    Console.WriteLine("Ramt");
                    Console.ReadLine();

                }

            }
            
        }

        internal string SætSkib(int d, char c, int f, int b)
        {

            //Sætter x og y
            Console.WriteLine("Indtast x-coordinaten");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast y-coordinat");

            int y = Convert.ToInt32(Console.ReadLine());

            bool Collision = false;

            

            //Rotation

            string Rotation = "";
           

                Console.WriteLine("Roter? y = vertikalt / n = Horizontalt");

                string RotationTemp = Console.ReadLine();

                if (RotationTemp == "y" && y <= 11 - d)
                {
                    Rotation = "y";

                    
                }
                else if (RotationTemp == "n" && x <= 11 - d)
                {

                    Rotation = "n";
                    
                }
                else
                {
                    //Console.WriteLine("Ugyldig rotation, prøv igen");
                    Collision = true;
                    
                }
            

            string Success = "";

            char ShipHidden = (char)b;

            
            //int ShipHidden = b;
            
            //d = SLength || type
            //c = skibstype (D || H)
            int Spiller = f;
            //hvis man vil lave flere spillere skal man ændre if(spiller == )

            int NulRotation = 0;
            int JaRotation = 0;

            //y = ja rotation, n = nej rotation
            
                //sætter -1 ved d da løkken laver skibene et tak for langt.
                if (x <= 11 - d && y <= 10)
                {

                    for (int i = 0; i <= d - 1; i = i + 1)
                    {
                        //intern rotation
                        if (Rotation == "n")
                        {
                            NulRotation = i;
                            JaRotation = 0;
                        }
                        else
                        {
                            NulRotation = 0;
                            JaRotation = i;
                        }

                            if (Spiller == 1)
                            {
                            if (GameBoard1[x + NulRotation - 1, y + JaRotation - 1] != ' ')
                            {
                                Collision = true;
                            }
                        }
                        else
                        {
                            if (GameBoard2[x + NulRotation - 1, y + JaRotation - 1] != ' ')
                            {
                                Collision = true;
                            }
                        }
                    }
                }

                if (x <= 11 - d && y <= 10 && !Collision)
                {
                    for (int i = 0; i <= d - 1; i = i + 1)
                    {
                        //intern rotation
                        if (Rotation == "n")
                        {
                            NulRotation = i;
                            JaRotation = 0;
                        }
                        else
                        {
                            NulRotation = 0;
                            JaRotation = i;
                        }

                        if (Spiller == 1)
                        {
                            GameBoard1[x + NulRotation - 1, y + JaRotation - 1] = c;
                            GameBoardHidden1[x + NulRotation - 1, y + JaRotation - 1] = ShipHidden;
                        }
                        else
                        {
                            GameBoard2[x + NulRotation - 1, y + JaRotation - 1] = c;
                            GameBoardHidden2[x + NulRotation - 1, y + JaRotation - 1] = ShipHidden;
                        }
                    }

                    Success = "Correct";
                }
                else
                {
                    Success = "Fejl";
                }
            

            if (f == 1)
            {
                Console.WriteLine(GetGameBoardView1());
            }
            else
            {
                Console.WriteLine(GetGameBoardView2());
            }
            return Success;

        }
    }

}
