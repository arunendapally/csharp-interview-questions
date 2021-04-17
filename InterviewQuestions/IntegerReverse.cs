using System;

namespace InterviewQuestions
{
    public class IntegerReverse
    {
        public static void Main()
        {
            Console.Write("Please enter a integer to reverse");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int i))
            {
                var sum = 0;
                while (i > 0)
                {
                    var rem = i % 10;
                    sum = (sum * 10) + rem;
                    i = i / 10;
                }
                Console.WriteLine($"Reverse of number {str} is {sum}");
            }
            else
            {
                Console.WriteLine($"{str} is not a valid integer, please enter a valid integer");
            }
        }
    }
}
