using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BattleshipMenu
    {

        //spiller = hvis tur det er under skyde fasen.
        bool Spiller1 = false;
        //bool PlaceringAfSkibe = true;
        bool PuttingShip = false;

        

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

            if (battleship != null )
            {
                

                if (!Spiller1 && PuttingShip)
                {
                    Console.WriteLine(battleship.GetGameBoardView1());
                    Console.WriteLine("Kamp fase! Spiller 1 skyd fjenden.");
                }
                else if(Spiller1 && PuttingShip)
                {
                    Console.WriteLine(battleship.GetGameBoardView2());
                    Console.WriteLine("Kamp fase! Spiller 2 skyd fjenden.");

                }
                else if(!PuttingShip)
                {
                    Console.WriteLine("Setup fase! Placer jeres skibe!");
                }
                
                //imellem spillere

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
            //Jeg blev træt af at klikke 1 med et uheld.
            Console.WriteLine("Er du sikker på du vil starte nyt spil? y for ja");
            if (Console.ReadLine() == "y")
            {
                battleship = new Battleship();
                PuttingShip = false;
            }


        }
        private void DoActionFor2()
        {
            int ShipLength = 0;
            char ShipName = ' ';

            

            int PuttingShipPlayer = 1;

            //Kan ikke sætte flere skibe
            if (PuttingShip)
            {
                Console.WriteLine("Kan ikke sætte flere skibe, skyd");
                Console.ReadLine();
            }
            //PuttingShipPlayer = 1 -> spiller 1, det samme for 2 -> spiller 2.

            while (!PuttingShip)
            {
                //int NumHangar = 1;
                //int NumBattleShip = 2;
                //int NumDestroyer = 2;
                //int NumUbåd = 1;
                //int NumPatruljeBåd = 3;

                //Alternativ for test
                int NumHangar = 0;
                int NumBattleShip = 0;
                int NumDestroyer = 1;
                int NumUbåd = 0;
                int NumPatruljeBåd = 2;

                int NumHiddenShips = 9;

                if (PuttingShipPlayer == 1)
                {
                    Console.WriteLine(battleship.GetGameBoardView1());
                }
                else
                {
                    Console.WriteLine(battleship.GetGameBoardView2());
                }

                //hangership
                while (NumHangar > 0)
                {
                    Console.WriteLine("Du har " + NumHangar + " Hangarskibe tilbage");

                    ShipLength = 5;
                    ShipName = 'H';
                    

                    //Løst problemet med grænser ved at sætte afgrænsninger.
                    if (battleship.SætSkib(ShipLength, ShipName, PuttingShipPlayer, NumHiddenShips) == "Correct")
                    {
                        NumHangar--;
                        NumHiddenShips--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }
                }

                //Battleship.
                while (NumBattleShip > 0)
                {
                    Console.WriteLine("Du har " + NumBattleShip + " slagskibe tilbage");

                    ShipLength = 4;
                    ShipName = 'B';

                    if (battleship.SætSkib(ShipLength, ShipName, PuttingShipPlayer, NumHiddenShips) == "Correct")
                    {
                        NumBattleShip--;
                        NumHiddenShips--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }
                }
                //Destroyer.
                while (NumDestroyer > 0)
                {
                    Console.WriteLine("Du har " + NumDestroyer + " destroyer tilbage");

                    ShipLength = 3;
                    ShipName = 'D';

                    if (battleship.SætSkib(ShipLength, ShipName, PuttingShipPlayer, NumHiddenShips) == "Correct")
                    {

                        NumDestroyer--;
                        NumHiddenShips--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }
                }

                //Ubåd
                while (NumUbåd > 0)
                {
                    Console.WriteLine("Du har " + NumUbåd + " ubåd tilbage");

                    ShipLength = 3;
                    ShipName = 'U';

                    if (battleship.SætSkib(ShipLength, ShipName, PuttingShipPlayer, NumHiddenShips) == "Correct")
                    {
                        NumUbåd--;
                        NumHiddenShips--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }
                }
                //patruljebåd
                while (NumPatruljeBåd > 0)
                {
                    Console.WriteLine("Du har " + NumPatruljeBåd + " patruljebåd tilbage");

                    ShipLength = 2;
                    ShipName = 'P';

                    if (battleship.SætSkib(ShipLength, ShipName, PuttingShipPlayer, NumHiddenShips) == "Correct")
                    {
                        NumPatruljeBåd--;
                        NumHiddenShips--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                       
                    }
                }
                Console.Clear();

                //Spiller valg
                PuttingShipPlayer++;
                if (PuttingShipPlayer >= 3)
                {
                    PuttingShip = true;
                }

            }
        }

        private void DoActionFor3()
        {
            //int spilletur = 1;

            if (PuttingShip)
            {
                if (Spiller1 == false)
                {
                    Console.WriteLine(battleship.GetGameBoardView1());
                    Console.WriteLine(battleship.GetGameBoardView3());
                }
                else
                {
                    Console.WriteLine(battleship.GetGameBoardView2());
                    Console.WriteLine(battleship.GetGameBoardView4());
                }

                char tur;

                //Denne while løkke bliver ved med at køre indtil man bruger break; da vi forventer korrekt valg.
                while (true)
                {
                    //den skal bruge til at tjekke om der er blevet sunket et skib
                    bool SunketStatus = false;

                    Console.Clear();

                    if (Spiller1 == false)
                    {
                        Console.WriteLine(battleship.GetGameBoardView1());
                        Console.WriteLine(battleship.GetGameBoardView3());
                        tur = '1';
                    }
                    else
                    {
                        Console.WriteLine(battleship.GetGameBoardView2());
                        Console.WriteLine(battleship.GetGameBoardView4());
                        tur = '2';
                    }

                    Console.WriteLine("Player " + tur);
                    Console.WriteLine("vælg x cordinaterne");

                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("vælg y cordinaterne");
                    int y = Convert.ToInt32(Console.ReadLine());

                    if (x <= 10 && x >= 0 && y <= 10 && y >= 0)
                    {
                        if (battleship.ValidateSunk(x, y, tur) == "Sunket")
                        {
                            SunketStatus = true;
                        }

                        battleship.Skydbrik(x, y, tur);

                        if (SunketStatus)
                        {
                            Console.WriteLine("Skib Sunket");
                            Console.ReadLine();
                        }

                        if (battleship.Validate() == "Winner")
                        {

                            if (!Spiller1)
                            {
                                Console.WriteLine("Spiller 1 har vundet");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Spiller 2 har vundet");
                                Console.ReadLine();
                            }

                            battleship = new Battleship();
                            PuttingShip = false;
                        }

                        if (Spiller1)
                        {
                            Spiller1 = false;
                        }
                        else if (!Spiller1)
                        {
                            Spiller1 = true;
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt valg, skyd inden for boarded");
                        Console.ReadLine();
                    }

                }

            }
            else
            {
                Console.WriteLine("Placer skibe først!");
                Console.ReadLine();
            }

        }
        
    }
}


