using System;



namespace spil
{

    public class TicTacToeMenu
    {
        //Hej

        int Gamecheck = 0;
        int Variation = 0;
        TicTacToe ticTacToe {get; set; }
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
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default : ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }
        static int spillertur = 0;
        
            
        private void ShowMenu()
        {
            Console.Clear();
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
            }
            Console.WriteLine("tic tac toe");
            Console.WriteLine();
            Console.WriteLine("1. Oret nyt spil");
            Console.WriteLine("2. Set en brik");
            Console.WriteLine("3. Flyt en brik");
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
            ticTacToe = new TicTacToe();
            spillertur = 0;
            Gamecheck = 1;
            Variation = 0;
            Console.WriteLine("Vælg Variation, tryk 1 for standart eller 2 for variation.");

            string VariationsValg = Console.ReadLine();
            if (VariationsValg == "1")
            {
                Variation = 0;
                Console.WriteLine("Du valgte 1");
                Console.ReadLine();
            }
            else if (/*Console.ReadLine() == "2"*/VariationsValg == "2")
            {
                Variation = 1;
                Console.WriteLine("Du valgte 2");
                Console.ReadLine();
            }
            else
            {
                ticTacToe = new TicTacToe();
                Console.WriteLine("Ugyldigt valg");
                Console.ReadLine();
            }
            

        }       
        private void DoActionFor2()
        {
            if (Variation == 0)
            {
                if (Gamecheck == 1)
                {
                    Console.WriteLine("sæt en brik");
                    char tur = 'o';

                    if (spillertur == 1 || spillertur == 3 || spillertur == 5 || spillertur == 7 || spillertur == 9)
                    {
                        tur = 'x';
                    }
                    else
                    {
                        tur = 'o';
                    }

                    Console.WriteLine(tur);
                    ticTacToe.Sætbrik(Console.ReadLine(), tur);


                    //ticTacToe.spillerturcheck = "forkert";
                    //if (ticTacToe.spillerturcheck == "to")
                    //{
                        spillertur++;
                    //}

                    //else if (ticTacToe.spillerturcheck == "forkert")
                    //{

                    //    spillertur = spillertur - 1;
                    //    //Console.WriteLine("lortet virker ikke");

                    //    //ticTacToe.spillerturcheck = 0;
                    //}
                    ticTacToe.Validate();
                    Console.ReadLine();
                    if (ticTacToe.winnerstring == "Winner")
                    {
                        DoActionFor1();
                    }
                    if (spillertur >= 10)
                    {
                        spillertur = 0;
                    }
                }
                else
                {
                    DoActionFor1();
                }
            }
            else if (Variation == 1)
            {
                if (spillertur < 6)
                {
                    Console.WriteLine("sæt en brik");
                    char tur = 'o';

                    if (spillertur == 1 || spillertur == 3 || spillertur == 5 || spillertur == 7 || spillertur == 9)
                    {
                        tur = 'x';
                    }
                    else
                    {
                        tur = 'o';
                    }

                    Console.WriteLine(tur);
                    ticTacToe.Sætbrik(Console.ReadLine(), tur);


                    //ticTacToe.spillerturcheck = "forkert";
                    
                    spillertur++;
                    ticTacToe.Validate();
                    if (ticTacToe.winnerstring == "Winner")
                    {
                        DoActionFor1();
                    }

                }
                else
                {
                    DoActionFor3();
                }
            }
        }
        
        private void DoActionFor3()
        {
            if (Variation == 1 && spillertur >= 6)
            {
                if (Gamecheck == 1)
                {
                    ticTacToe.briktest = 0;
                    Console.WriteLine("vælg en brik at flytte");
                    char tur = 'o';

                    if (spillertur == 1 || spillertur == 3 || spillertur == 5 || spillertur == 7 || spillertur == 9)
                    {
                        tur = 'x';
                    }
                    else
                    {
                        tur = 'o';
                    }

                    Console.WriteLine(tur);
                    ticTacToe.sletbrik(Console.ReadLine(), tur);
                    ticTacToe.Validate();

                    if (ticTacToe.briktest == 0)
                    {
                        Console.WriteLine("sæt en brik");


                        if (spillertur == 1 || spillertur == 3 || spillertur == 5 || spillertur == 7 || spillertur == 9)
                        {
                            tur = 'x';
                        }
                        else
                        {
                            tur = 'o';
                        }

                        Console.WriteLine(tur);
                        ticTacToe.Sætbrik(Console.ReadLine(), tur);


                        //ticTacToe.spillerturcheck = "forkert";

                        spillertur++;
                        ticTacToe.Validate();
                        
                        if (ticTacToe.winnerstring == "Winner")
                        {
                            DoActionFor1();
                        }
                        if (spillertur >= 10)
                        {
                            spillertur = 6;
                        }
                    }
                    else
                    {
                        DoActionFor3();
                    }


                }

                else
                {
                    DoActionFor1();
                }
            }
            else if (spillertur < 6)
            {
                Console.WriteLine("Ugyldigt valg sæt 6 brikker ført");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Forkert valg, vælg variation 2 for at flytte brikker");
                Console.ReadLine();
            }
        }
    }
}