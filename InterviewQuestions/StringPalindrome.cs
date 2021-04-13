using System;
using System.Text;

namespace InterviewQuestions
{
    class StringPalindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to check if it is palindrome: ");
            string str = Console.ReadLine();
            StringBuilder revStr = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr.Append(str[i]);
            }
            Console.WriteLine($"The string is {(revStr.ToString() == str ? "Palindrome" : "not a Plaindrome")}");
        }
    }
}
