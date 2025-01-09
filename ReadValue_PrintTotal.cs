using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class ReadValue_PrintTotal
    {
        /*
         * Create a 10 length int array
         * Loop through array and ask user for 10 number input's
            * Store all inputs in the array
         * Loop through the array and calculate the total
         * Output the average 
         * Why are we using 2 loops here? Why not in one? Practise
         * Extra: define a const for the count and use it as much as possible
        */
        static void Main(string[] args)
        {
            const int numCount = 5;
            int[] numbers = new int[numCount];

            /*int i = 0;
            foreach (var item in numbers)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine()); //0
                i++;
            }*/

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;

            foreach (var item in numbers)
            {
                //total = total + item;
                total += item;
            }

            /*int total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number: ");
                total += Convert.ToInt32(Console.ReadLine()); //123
            }*/

            Console.WriteLine(total);

            double average = total / Convert.ToDouble(numCount);
            Console.WriteLine(average);

            Console.ReadLine();
        }
    }
}
