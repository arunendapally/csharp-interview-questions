using System;
using System.Text;

namespace InterviewQuestions
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to reverse: ");
            string str = Console.ReadLine();
            StringBuilder revStr = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr.Append(str[i]);
            }
            Console.WriteLine($"The reversed string is {revStr}");
        }
    }
}
