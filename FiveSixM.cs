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
                //win 
                if (uC == 1 && cC == 3 || uC == 2 && cC == 1 || uC == 3 && cC == 2)
                {
                    wallet += bet;
                    counterU++;
                    
                } 
                //tie
                else if (uC == 0){
                    break;
                }
                // lose
                else 
                {
                    wallet -= bet;
                    counterC++;
                }

                Console.WriteLine("\tUser score and wallet, respectively: "+counterU+ " & "+wallet);
                Console.WriteLine("\tComputer score: "+counterC);

                if (counterC == 4 || counterU ==4){
                    break;
                }

            }

            Console.WriteLine("Gameover!");

            
    

        }
    }
}