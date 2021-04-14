using System;

namespace InterviewQuestions
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer to get factorial: ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int i))
            {
                int factorial = GetFactorial(i);
                Console.WriteLine($"The factorial of the number {i} is {factorial}");
            }
            else
            {
                Console.WriteLine($"{str} is not a valid integer, please enter valid integer");
            }
        }

        // Recursion
        private static int GetFactorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            return i * GetFactorial(i - 1);
        }
    }
}