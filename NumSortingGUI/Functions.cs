using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSortingGUI
{
    /// <summary>
    /// Generates X random numbers
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
            
            int b;
            try
            {
                for (int c = 0; c < genlist.Count - 1; c++)
                {
                    for (int i = 0; i < genlist.Count - 1; i++)
                    {
                        if (genlist[i] > genlist[i + 1])
                        {
                            b = genlist[i + 1];
                            genlist[i + 1] = genlist[i];
                            genlist[i] = b;
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine("Genlist empty");
            }
            

            return genlist;
        }
        internal static List<int> BubbleSort(List<int> genlist, out TimeSpan timeElapsed)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            genlist = BubbleSort(genlist);

            stopWatch.Stop();
            timeElapsed = stopWatch.Elapsed;
            return genlist;
        }
    }
}
