using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcu
{
    /// <summary>
    /// Generates 10 random numbers
    /// </summary>
    class Functions
    {
        int[] GenerateNumbers()
        {
            int[] randomNumbers = new int[9];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                randomNumbers[i] = rand.Next(0, 101);

            }
            return randomNumbers;
        }
    }       
}
