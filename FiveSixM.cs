using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFiveSix
{
    class FiveSixM
    {
        public static double getInput(){
            string inx;
            Console.WriteLine("Choose numerically: rock '1', paper '2', scissors '3'...Go!");
            inx = Console.ReadLine();
            double inPut = double.Parse(inx);
            return inPut;
        }
        public static void Main()
        {
                double bet = 10;
                double wallet = 100;
                int counterU =0;
                int counterC = 0;
                double uC;
                double cC;
                Random rnd = new Random();

            while (wallet > 0)
            {
                uC = getInput();
                cC = rnd.Next(1, 4);
                FiveSix1 game = new FiveSix1();
                

                //win 
                if (uC == 1 && cC == 3 || uC == 2 && cC == 1 || uC == 3 && cC == 2)
                {
                    wallet = game.calcWin(wallet,bet);
                    counterU++;              
                } 
                //tie
                else if (uC == 0){
                    break;
                }
                // lose
                else 
                {
                    wallet = game.calcLose(wallet,bet);
                    counterC++;
                }

                Console.WriteLine("\tWallet amount: $"+wallet);
                Console.WriteLine("\tComputer score: "+counterC);
                Console.WriteLine("\tUser score: "+counterU);

                if (counterC == 4 || counterU ==4){
                    break;
                }

            }

            Console.WriteLine("Gameover!");
            

            /* if (wallet > 100){
                Console.WriteLine("\tYou made $"+ wallet-100 +"dollars.");
            }
            else {
                Console.WriteLine("\tYou lost $"+ 100-wallet +"dollars.");
            }*/ 

            
    

        }
    }
}