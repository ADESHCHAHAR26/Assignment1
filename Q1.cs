using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q1
    {
        public static void Qs1(){
            int[] transactions = new int[] { 200, -150, 340, 500, -100 };
            int totaltransaction = 0;
            for (int i = 0; i < transactions.Length; i++)
            {
                totaltransaction += transactions[i];
            }
            Console.WriteLine(totaltransaction);

        }
    }
}
