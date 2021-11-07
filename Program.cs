using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
              Random r = new Random();
            string durum = "y";
            int Alicoin = 100, kulcoin, kulan, kulan1, zar = 0, zar1 = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First of all, hello, our game is a dice game, two dice are thrown, if you know both, you will get 2x the amount of your deposit EXAMPLE: your guess is 5-4, the result is 2-1");
            Console.WriteLine();
            while (durum == "Y" || durum == "y")
            {
                zar = r.Next(1, 7);
                zar1 = r.Next(1, 7);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Remaining coins = " + Alicoin + "| " + "Please write how much you want to play = ");
                kulcoin = Convert.ToInt32(Console.ReadLine());
                if(kulcoin>Alicoin)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME BREAKER");
                    break;
                }
                Alicoin = Alicoin - kulcoin;
                Console.Write("Please enter numbers 1 to 6 = ");
                kulan = Convert.ToInt32(Console.ReadLine());
                if (kulan < 1 || kulan > 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You entered the wrong number");
                    break;
                }
                Console.Write("Please enter numbers 1 to 6 = ");
                kulan1 = Convert.ToInt32(Console.ReadLine());
                if (kulan1 < 1 || kulan1 > 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You entered the wrong number");
                    break;
                }
           
                if (kulan != zar || kulan1 != zar1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unfortunately you didn't know = " + zar + "-" + zar1 + " " + "Remaining coins = " + Alicoin);

                }
                else
                {
                    kulcoin = kulcoin * 2;
                    Alicoin = Alicoin + kulcoin;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("congratulations you won = "+zar+"-"+zar1+" "+ "TOTAL COINS = " + Alicoin);
                }


                Console.WriteLine();
                Console.Write("Do you want to continue? (y/n)");
                durum = Console.ReadLine();
                if(Alicoin==0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No coins, start again");
                    break;
                }
                if (Alicoin > 1 && Alicoin < 20)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("IF YOU CAN'T DO THIS, CLOSE THE GAME!");
                }
                if (Alicoin > 20 && Alicoin < 40)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("you are a disgrace");
                }
                if (Alicoin > 40 && Alicoin < 60)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DON'T UNDERSTAND MY GAME");
                }
                if (Alicoin > 60 && Alicoin < 80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Yes it takes some luck");
                }
                if (Alicoin > 80 && Alicoin < 100) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Can still recover");
                }
                if (Alicoin > 500 && Alicoin < 1000) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("YOU SOLVE THIS JOB CONTINUE");
                }
                if (Alicoin > 1000 && Alicoin < 5000) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("YOU GOT THE WIND BACK");
                }
                if (Alicoin > 5000 && Alicoin < 10000) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("THIS BUSINESS STARTED TO GET BAD");
                }
                if (Alicoin > 10000) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("YOU ARE A FULL GAMPER");
                    Console.WriteLine("Gambling is BAD");
                    break;
                }
               
            }
          
            Console.ReadKey();

        }
    }
}
