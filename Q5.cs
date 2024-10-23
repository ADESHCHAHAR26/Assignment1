using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q5
    {
        public static void Qs5()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.Write(searchHistory[i] + " ");

            }
        }
    }
}
