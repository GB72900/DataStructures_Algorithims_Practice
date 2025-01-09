using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class ReadValue_Search
    {
        /*
         * Create a 3 sized int array
         * Insert custom user values into the array using a for loop
         * Ask user for a number to search
         * The index doesn't matter, just determine if the value is in the array
         * If found, output "Your number is in the list!"
         * If not found, output "Your number is not in the list!"
        */
        static void Main(string[] args)
        {
            /*List<int> numbers = new List<int>(3);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int index = numbers.IndexOf(search);

            Console.WriteLine(numbers.Contains(search) ? "Found" : "Not found");
            Console.WriteLine(index > -1 ? "Found" : "Not found");

            if (numbers.Contains(search))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }*/

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int index = Array.IndexOf(numbers, search);
            bool found = false;

            // 1 1 1 

            foreach (var item in numbers)
            {
                Console.WriteLine($"test {item}");
                if (search.Equals(item))
                {
                    found = true;
                }
            }
            //

            if (index > -1)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            //Console.WriteLine(index > -1 ? "Found" : "Not found");
            Console.WriteLine(found ? "Found" : "Not found");
            Console.ReadLine();
        }
    }
}
