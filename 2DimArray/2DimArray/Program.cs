using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2DimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twodim = new int[,] { { 1, 2, 3 }, { 9, 8, 7 } };

            int dim1 = twodim.GetLength(0);
            int dim2 = twodim.GetLength(1);

            WriteLine("Dimension 0 contains {0} elements.", dim1);
            WriteLine("Dimension 1 contains {0} elements.\n", dim2);

            for (int i1 = 0; i1 < dim1; i1++)
            {
                for (int i2 = 0; i2 < dim2; i2++)
                {
                    WriteLine("twodim[{0},{1}] = {2}", i1, i2, twodim[i1, i2]);
                }
            }
            ReadLine();

        }
    }
}
