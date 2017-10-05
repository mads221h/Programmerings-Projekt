using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class  GameMenu
    {
        //bool playerOne = true;
        public void Show()
        {
            bool running = true;
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }

        


        private void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("Vælg Spil:");
            Console.WriteLine();
            Console.WriteLine("1. Spil TicTacToe");
            Console.WriteLine("2. Spil Battleship");

            Console.WriteLine();
            Console.WriteLine("0. exit");
        }

        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShowMenuSelectionErroe()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
        }

        private void DoActionFor1()
        {
            TicTacToeMenu ticTacToeMenu = new TicTacToeMenu();
            ticTacToeMenu.Show();
        }
        private void DoActionFor2()
        {
            BattleshipMenu battleshipMenu = new BattleshipMenu();
            battleshipMenu.show();
        }

    }
}

