using System;

namespace InterviewQuestions
{
    public class ExtensionMethodExample
    {
        static void Main(string[] args)
        {
            int i = 4;
            Console.WriteLine(i.IsGreaterThan5());

            i = 8;
            Console.WriteLine(i.IsGreaterThan5());

            i = 15;
            Console.WriteLine(i.IsDivisibleByGivenNumber(5));

            i = 11;
            Console.WriteLine(i.IsDivisibleByGivenNumber(5));
        }
    }

    public static class MyExtensionMethod
    {
        public static bool IsGreaterThan5(this int i)
        {
            if (i > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsDivisibleByGivenNumber(this int i, int j)
        {
            if (i % j == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
