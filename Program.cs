using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> numbers = new List<int>{500, 3, 23, 4, 21, 100, 400};
            int[] numbers = {12, 500, 3, 23, 4, 21, 100, 400};

            // int width = 5;
            // int height = 5;
            // CreateSquare(width, height, "+");

            SortArray(numbers);

            // CheckIfOlympicsYear();

            // CreateLeftTriangle();
        }

        public static int Sum(int[] numbers)
        {
            int head = numbers[0];
            int[] tail = numbers.Skip(1).ToArray();
            if (tail.Length != 0) return head += Sum(tail);
            else return head;
        }

        public static void SortArray(int[] array)
        {
            int temp = 0;
            for (int x = 0; x <= array.Length; x++)
            {
                for (int y = 0; y < array.Length - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
                }
            }

            foreach (int z in array)
            {
                Console.WriteLine(z);
            }
        }

        public static void CreateSquare(int width, int height, string symbol)
        {
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    if (x == 0 || x == (height - 1))
                    {
                        Console.Write(symbol);
                    } else
                    {
                        if (y == 0 || y == height - 1)
                        {
                            Console.Write(symbol);
                        } else {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void CheckIfOlympicsYear()
        {
            Console.Write("Olympic year: ");

            int year;
            bool isInteger = int.TryParse(Console.ReadLine(), out year);

            if (isInteger)
            {
                int firstOlympics = 1896;

                if (year < firstOlympics) {
                    Console.WriteLine("First Olympics not started");
                } else if (year >= firstOlympics && year % 4 == 0) {
                    Console.WriteLine("Olympic Game");
                } else {
                    Console.WriteLine("Not olympic game");
                }
            } else {
                Console.WriteLine("Error parsing integer");
            }
        }

        public static void CreateLeftTriangle()
        {
            Console.Write("enter number: ");

            int n;
            bool isInteger = int.TryParse(Console.ReadLine(), out n);

            if (isInteger)
            {
                for (int x = 0; x < n; x++)
                {

                    for (int y = 0; y <= x; y++)
                    {
                        if (y == 0  || y == x || x == n - 1) Console.Write(" +");
                        else Console.Write(" -");
                    }

                    Console.WriteLine();
                }
            } else Console.WriteLine("Error parsing integer");
        }
    }
}
