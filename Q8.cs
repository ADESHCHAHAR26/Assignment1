using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q8
    {
        public static void Qs8()
        {
            int[] grades = { 56, 78, 89, 45, 79 };
            int largest = 0;
            int secLargest = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > largest)
                {
                    largest = grades[i];
                }
            }
            for (int i = 0; i < grades.Length; i++)
            {
                    if(grades[i] > secLargest && grades[i] != largest)

                {
                    secLargest = grades[i];
                    
                }
            }
            Console.WriteLine(secLargest);


        }

    }
}
