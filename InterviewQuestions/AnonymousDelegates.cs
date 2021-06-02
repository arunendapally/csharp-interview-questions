using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class AnonymousDelegates
    {
        public delegate int PerformCalculation(int i, int j);
        public static void Main()
        {
            PerformCalculation addition = delegate (int i, int j)
            {
                return i + j;
            };
            Console.WriteLine($"Addition of two numbers {addition(10, 20)}");
        }
    }
}
