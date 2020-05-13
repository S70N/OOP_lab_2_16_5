using System;

namespace OOP_lab_2_16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмiри матрицi: ");

            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[][] A = new int[int.Parse(elements[0])][];

            var random = new Random();

            for (int i = 0; i < A.Length; ++i)
            {
                A[i] = new int[int.Parse(elements[1])];

                for (int j = 0; j < A[i].Length; ++j)
                {
                    A[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    Console.Write("{0, -5}", A[i][j]);
                }

                Console.WriteLine();
            }

            Console.Write("\nКоординати першого елемента: ");

            elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int d = A[int.Parse(elements[0])][int.Parse(elements[1])];

            Console.Write("Координати другого елемента: ");

            elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            d *= A[int.Parse(elements[0])][int.Parse(elements[1])];

            Console.Write("\nРезультат множення елементiв: {0}", d);
        }
    }
}
