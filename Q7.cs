using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q7
    {
        public static void Qs7()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (searchCode == bookCodes[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
       
    }
}