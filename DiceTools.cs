using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission02
{

    internal class DiceTools
    {
        // import random library to create random number generation
        Random rnd = new Random();

        public int RollCounter(int Rolls)
        {
            // set both dice - doing this so the output proportion is similar to an actual dice probability
            
            int[] RollValues = new int[13];


            for (int i = 0; i < Rolls; i++)
            {
                int rollDie1 = 0;
                int rollDie2 = 0;
                int rollCount = 0;

                // assign random values to dice 1-6
                rollDie1 = rnd.Next(1, 7);
                rollDie2 = rnd.Next(1, 7);

                // combine dice output
                rollCount = rollDie1 + rollDie2;


                // add dice roll count to the array of possible dice roll values
                RollValues[rollCount]++;
            }

            // print out the results
            for (int i = 2; i < 13; i++)
            {
                string Rollstars = "";

                // take the total rolls of that value and divide it by the total requested roll count
                int Stars = (RollValues[i]*100) / (Rolls);
                
                // concat all the possible stars
                for (int j = 0; j < Stars; j++)
                {
                    Rollstars = Rollstars + "*";
                }

                // print the stars and numbers
                Console.WriteLine(i + ": " + Rollstars + " ");
            }

            return 0;
        }
    
    }

    

   
}
