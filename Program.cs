using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR2020_10_PatternLikePyramidwithasterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i=0; i<5; i++) //(starting point; stoping point; incrementer)
            //Display the pattern like right angle triangle which repeat a number in a row:
            int i, j;

            int rows = 13;

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", i);
                Console.Write("\n");
            }
            Console.ReadLine();        
        }

    }
}

