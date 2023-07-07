namespace PrepCodeChallenges;
using PrepCodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        static void PrepChallenge3()
        {
            int play = 0;
            do
            {

                Console.WriteLine("Enter 5 numbers");
                int[] numbers = new int[3];
                int sum = 0;
                int product = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput >= 0)
                    {
                        numbers[i] = userInput;
                        sum += numbers[i];
                        product *= numbers[i];

                    }

                }
                if (sum == product)
                {
                    Console.WriteLine("Perfect Sequence Detected");
                }
                else
                {
                    Console.WriteLine("Perfect Sequence Not found");
                    Console.WriteLine(product);
                }


            } while (play == 0);

        }
        PrepChallenge3();

    }
}