using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2D3DArrays
{
    class Program
    {
        static void Main()
        {
            /*  create a one-dimensional array of integers */
            /*  NOTE:  array indices start with zero */
            int[] Scores = new int[] { 105, 92, 81, 93, 100 };

            /* loop through the following loop 5 times - once for each element of our Scores array */
            for (int i = 0; i < 5; i++)
            {
                WriteLine("The " + i + " index of our array contains " + Scores[i]);
            }
            ReadLine();
        }
    }
}
