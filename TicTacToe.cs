using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class TicTacToe
    {
        /*
         * Create and initalise char array with 'X' and 'O' randomly
         * Use two for loops to print the board to the console
         * Extra: output a board thats similar to TicTacToe with lines
        */
        static void Main(string[] args)
        {
            char[,] board = new char[,]
            {
                { 'X', 'X', 'X' },
                { 'O', 'O', 'X' },
                { 'O', 'O', 'X' }
            };

            for (int i = 0; i < board.GetLength(0); i++) //Row
            {
                for (int j = 0; j < board.GetLength(1); j++) //Columns
                {
                    Console.Write($"| {board[i,j]} ");
                }

                Console.WriteLine("|");
                if (i < board.GetLength(0) - 1) //3-1 = 2
                    Console.WriteLine("-------------");// 0 1 2
            }

            Console.ReadLine();
        }
    }
}
