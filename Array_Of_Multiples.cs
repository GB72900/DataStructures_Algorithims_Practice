using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Array_Of_Multiples
    {
        /*
         * Define and initalise two integers (num, length)
         * (7, 5) -> [7, 14, 21, 28, 35]
         * Create int array with size length
         * Loop through and insert the (loop counter * num) into the array
         * Print final array
        */
        static void Main(string[] args)
        {
            int num = 10;
            int length = 10;
            int[] result = new int[length];
            int counter = 0;

            for (int i = 1; i <= result.Length; i++, counter++) // 0 - 4  1 - 5
            {
                result[counter] = num * i;
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
