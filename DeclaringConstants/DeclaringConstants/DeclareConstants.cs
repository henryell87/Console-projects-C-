using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class DeclareConstants
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            // constantt decleration

            double r;
            Console.WriteLine("Enter Raadiuus:");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();

        }
    }
}
