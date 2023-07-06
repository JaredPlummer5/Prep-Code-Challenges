namespace PrepCodeChallenges;
using PrepCodeChallenges;

class Program
{
    static void Main(string[] args)
    {
        static void PrepChallenge1()
        {
            int play = 0;
            do
            {

                Console.WriteLine("Code Challenge 1");
                Console.WriteLine("Choose 5 numbers between 1 & 10");
                int[] nums = new int[5];
                try
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] = Convert.ToInt32(Console.ReadLine());
                        //while (!(nums[i] > 0 && nums[i] <= 10))
                        //{
                          

                          
                        //    Console.WriteLine("Try again");

                            

                        //}



                    }
                    Console.WriteLine("Your Array is: ");
                    for (int i = 0; i < nums.Length; i++)
                    {
                        Console.Write(nums[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Choose a numder from the array, pls");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    int score = 0;
                    if (!nums.Contains(choice))
                    {
                        Console.WriteLine("Your Score is: " + 0);
                    }
                    else
                    {
                        foreach (int num in nums)
                        {
                            if (num == choice)
                            {
                                score += num;
                            }
                        }
                        Console.WriteLine("Your score is:" + score);
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("We Goofed");
                    Console.WriteLine(err.ToString());
                }
                finally
                {
                    Console.WriteLine("The Game is Over");
                }
            } while (play == 0);
        }
        PrepChallenge1();
    }
}
