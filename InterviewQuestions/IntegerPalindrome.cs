using System;

namespace InterviewQuestions
{
    class IntegerPalindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer to check if it is palindrome: ");
            string str = Console.ReadLine();
            int i, sum = 0;
            if (int.TryParse(str, out i))
            {
                int temp = i;
                while (i > 0)
                {
                    var remainder = i % 10;
                    sum = (sum * 10) + remainder;
                    i = i / 10;
                }
                Console.WriteLine($"The integer is {(temp == sum ? "Palindrome" : "not a Plaindrome")}");
            }
            else
            {
                Console.WriteLine($"{str} is not a valid integer, please enter valid integer");
            }
        }
    }
}
