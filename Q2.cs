using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q2
    {
        public static void Qs2()
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float avg = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                avg += scores[i] / scores.Length;
            }
            Console.WriteLine(avg);
        }
    }
}