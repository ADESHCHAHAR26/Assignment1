using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Q4
    {
        public static void Qs4()
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int count1 = 0; ;
            int count2 = 0;
            for(int i = 0; i< participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }

            Console.WriteLine("Number of Man " + count1 + " Number of Woman " + count2 );
        }
    }
}
