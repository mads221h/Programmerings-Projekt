using System;
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
                Console.WriteLine(battleship.GetGameBoardView2());
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

            int ShipLength = 0;
            char ShipName = ' ';

            
            int NumHangar = 1;
            int NumBattleShip = 2;
            int NumDestroyer = 2;
            int NumUbåd = 1;
            int NumPatruljeBåd = 3;

            string Rotation = "";

            //Skibslængden skal være 1 mindre.

            bool PuttingShip = false;

            //ændre til 1 Husk mig!
            int PuttingShipPlayer = 2;

            //går igennem 2 gange: vi skal lave en værdi som stiger til 2

            //PuttingShipPlayer = 1 -> spiller 1, det samme for 2 -> spiller 2.

            while (!PuttingShip)
            {
                //hangership
                while (NumHangar > 0)
                {

                    Console.WriteLine("Du har " + NumHangar + " Hangarskibe tilbage");

                    Console.WriteLine("Indtast x-coordinaten");

                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Indtast y-coordinat");

                    int y = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {

                        Console.WriteLine("Roter? y/n");

                        string RotationTemp = Console.ReadLine();

                        if(RotationTemp == "y")
                        {
                            Rotation = "y";

                            break;
                        }else if(RotationTemp == "n")
                            {

                            Rotation = "n";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt valg, prøv igen");
                        }

                    }

                    ShipLength = 5;
                    ShipName = 'H';

                    //Løst problemet med grænser ved at sætte afgrænsninger.
                    if (battleship.SætSkib(x, y, ShipLength, ShipName, Rotation) == "Correct")
                    {
                        battleship.SætSkib(x, y, ShipLength, ShipName, Rotation);

                        NumHangar--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }


                    Console.WriteLine(battleship.GetGameBoardView2());


                }


                //Battleship.
                while (NumBattleShip > 0)
                {
                    Console.WriteLine("Du har " + NumBattleShip + " slagskibe tilbage");

                    Console.WriteLine("Indtast x-coordinaten");

                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Indtast y-coordinat");

                    int y = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {

                        Console.WriteLine("Roter? y/n");

                        string RotationTemp = Console.ReadLine();

                        if (RotationTemp == "y")
                        {
                            Rotation = "y";

                            break;
                        }
                        else if (RotationTemp == "n")
                        {

                            Rotation = "n";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt valg, prøv igen");
                        }

                    }

                    ShipLength = 4;
                    ShipName = 'B';


                    
                    if (battleship.SætSkib(x, y, ShipLength, ShipName, Rotation) == "Correct")
                    {
                        battleship.SætSkib(x, y, ShipLength, ShipName, Rotation);

                        NumBattleShip--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }

                    Console.WriteLine(battleship.GetGameBoardView2());
                    


                }
                //Destroyer.
                while (NumDestroyer > 0)
                {
                    Console.WriteLine("Du har " + NumDestroyer + " destroyer tilbage");

                    Console.WriteLine("Indtast x-coordinaten");

                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Indtast y-coordinat");

                    int y = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {

                        Console.WriteLine("Roter? y/n");

                        string RotationTemp = Console.ReadLine();

                        if (RotationTemp == "y")
                        {
                            Rotation = "y";

                            break;
                        }
                        else if (RotationTemp == "n")
                        {

                            Rotation = "n";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt valg, prøv igen");
                        }

                    }

                    ShipLength = 3;
                    ShipName = 'D';

                    if (battleship.SætSkib(x, y, ShipLength, ShipName, Rotation) == "Correct")
                    {
                        battleship.SætSkib(x, y, ShipLength, ShipName, Rotation);

                        NumDestroyer--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }


                    Console.WriteLine(battleship.GetGameBoardView2());
                    


                }

                //Destroyer.
                while (NumUbåd > 0)
                {
                    Console.WriteLine("Du har " + NumUbåd + " ubåd tilbage");

                    Console.WriteLine("Indtast x-coordinaten");

                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Indtast y-coordinat");

                    int y = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {

                        Console.WriteLine("Roter? y/n");

                        string RotationTemp = Console.ReadLine();

                        if (RotationTemp == "y")
                        {
                            Rotation = "y";

                            break;
                        }
                        else if (RotationTemp == "n")
                        {

                            Rotation = "n";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt valg, prøv igen");
                        }

                    }

                    ShipLength = 3;
                    ShipName = 'U';

                    if (battleship.SætSkib(x, y, ShipLength, ShipName, Rotation) == "Correct")
                    {
                        battleship.SætSkib(x, y, ShipLength, ShipName, Rotation);

                        NumUbåd--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }


                    Console.WriteLine(battleship.GetGameBoardView2());
                    


                }

                //Destroyer.
                while (NumPatruljeBåd > 0)
                {
                    Console.WriteLine("Du har " + NumPatruljeBåd + " patruljebåd tilbage");

                    Console.WriteLine("Indtast x-coordinaten");

                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Indtast y-coordinat");

                    int y = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {

                        Console.WriteLine("Roter? y/n");

                        string RotationTemp = Console.ReadLine();

                        if (RotationTemp == "y")
                        {
                            Rotation = "y";

                            break;
                        }
                        else if (RotationTemp == "n")
                        {

                            Rotation = "n";
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt valg, prøv igen");
                        }

                    }

                    ShipLength = 2;
                    ShipName = 'P';

                    if (battleship.SætSkib(x, y, ShipLength, ShipName, Rotation) == "Correct")
                    {
                        battleship.SætSkib(x, y, ShipLength, ShipName, Rotation);

                        NumPatruljeBåd--;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig position, prøv igen.");
                        Console.ReadLine();
                    }


                    Console.WriteLine(battleship.GetGameBoardView2());
                    


                }

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


