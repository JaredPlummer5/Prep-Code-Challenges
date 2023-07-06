namespace PrepCodeChallenges;
using PrepCodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        static void PrepChallenge2()
        {
            int play = 0;
            do
            {

                Console.WriteLine("Enter a year");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0 || (year % 100 == 0 && year % 400 == 0))
                {
                    Console.WriteLine("This is a leap year");
                }
                else
                {
                    Console.WriteLine("This is not a leap year");
                }

            } while (play == 0);

        }
            PrepChallenge2();
    }
}
