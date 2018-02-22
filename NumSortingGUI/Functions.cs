using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSortingGUI
{
    /// <summary>
    /// Generates 10 random numbers
    /// </summary>
    internal class Functions
    {
        internal static List<int> GenerateNumbers(int howMany)
        {
            List<int> genlist = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < howMany; i++)
            {
                genlist.Add(rand.Next(0, 101));
                Debug.WriteLine(genlist[i]);
            }
            return genlist;
        }

        internal static List<int> BubbleSort(List<int> genlist)
        {
            List<int> sortedBubble = new List<int>();


            return sortedBubble;
        }

    }
}
