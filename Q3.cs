using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q3
    {
        public static void Qs3()
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int expensive = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > expensive)
                {
                    expensive = prices[i];
                }
            }
            Console.WriteLine(expensive);
        }
    }
}
