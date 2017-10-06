﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BattleshipMenu
    {
        

        Battleship battleship { get; set; }
        public void show()
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
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.Clear();
            if (battleship != null)
            {
                Console.WriteLine(battleship.GetGameBoardView());
            }

            Console.WriteLine("Battleship");
            Console.WriteLine();
            Console.WriteLine("1. Opret nyt spil");
            Console.WriteLine("2. Sæt dine skibe");
            Console.WriteLine("3. Skyd skibe");
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
            battleship = new Battleship();

        }
        private void DoActionFor2()
        {

            int SLength = 3;
            
            Console.WriteLine("Indtast x-coordinaten");
          
            int x = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("Indtast y-coordinat");

           int y = Convert.ToInt32(Console.ReadLine());

            

            battleship.SætSkib(x, y, SLength, 'd');

            //Battleship.

        }
        private void DoActionFor3()
        {
            
        int spilletur = 1;
            char tur;
            if (spilletur == 0)
            {
                tur = '1';
            }
            else if (spilletur == 1)
            {
                tur = '2';
            }
            else
            {
                tur = '1';
            }
            Console.WriteLine("Player " + tur);
            Console.WriteLine("vælg x cordinaterne");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vælg y cordinaterne");
            int y = Convert.ToInt32(Console.ReadLine());
            battleship.Skydbrik(x, y, tur);
            battleship.Validate();

        }
    }
}


