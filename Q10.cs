using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q10
    {
        public static void Qs10()
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 }; 
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            int[] result  = new int[dataset1.Length];
            int index = 0;
            for (int i = 0; i < dataset1.Length; i++)
            {
                for (int j = 0; j < dataset2.Length; j++)
                {
                    if (dataset1[i] == dataset2[j])
                    {
                        result[index++] = dataset1[i];
                    }
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }
    }
}
