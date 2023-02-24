using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    // Static class because we want the code to get run once on this page then returned
    public static class DiceRoll
    {

        // To make this an extension method, include the word "this"
        public static int RollTheDie(this string
            numberOfSides)
        {
            int maxSide = int.Parse(numberOfSides) + 1;

            int minSide = 1;

            Random rand = new Random();
            return rand.Next(minSide, maxSide);
            
        }

    }
}
