using System;

namespace PrepCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepChallenge4();
        }

        static void PrepChallenge4()
        {
            int play = 0;
            do
            {
                Console.WriteLine("Enter the number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number of columns: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                int[,] myArray = new int[rows, columns];
                int[] sumArray = new int[rows];

                for (int i = 0; i < rows; i++)
                {
                    int sum = 0;
                    Console.WriteLine($"Enter {columns} numbers for row {i + 1}:");
                    for (int j = 0; j < columns; j++)
                    {
                        myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                        sum += myArray[i, j];
                    }
                    sumArray[i] = sum;
                }

                Console.WriteLine("The sum of each row:");
                foreach (int sum in sumArray)
                {
                    Console.WriteLine(sum);
                }

                Console.WriteLine("Done!!!");

            } while (play == 0);
        }
    }
}
