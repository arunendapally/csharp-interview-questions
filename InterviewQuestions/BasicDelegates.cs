using System;

namespace InterviewQuestions
{
    public class BasicDelegates
    {
        public delegate int PerformCalculation(int i, int j);
        public static void Main()
        {
            PerformCalculation performCalculation = Add;
            Console.WriteLine($"Addition of two numbers {performCalculation(10, 20)}");

            performCalculation = Multiply;
            Console.WriteLine($"Multiplication of two numbers {performCalculation(10, 20)}");

            AdditionalOperations additionalOperations = new AdditionalOperations();
            performCalculation = additionalOperations.Substractions;
            Console.WriteLine($"Substractions of two numbers {performCalculation(20, 10)}");

        }

        public static int Add(int i, int j)
        {
            return i + j;
        }

        public static int Multiply(int i, int j)
        {
            return i * j;
        }
    }

    public class AdditionalOperations
    {
        public int Substractions(int i, int j)
        {
            return i - j;
        }
    }
}
