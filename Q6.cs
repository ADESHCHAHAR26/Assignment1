using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q6
    {
        public static void Qs6()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] *= factor;
            }
            for (int i = 0; i < measurements.Length; i++)
            {
                Console.WriteLine(measurements[i]);
            }
            Console.ReadLine();
        }
    }
}
