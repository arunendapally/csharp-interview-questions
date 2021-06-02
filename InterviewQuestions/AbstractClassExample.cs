using System;

namespace InterviewQuestions
{
    public abstract class MyAbstractClass
    {
        public abstract void Print();

        public void SayHello()
        {
            Console.WriteLine("This is Abstract class");
        }
    }

    public class DerivedClass : MyAbstractClass
    {
        public static void Main()
        {
            MyAbstractClass c = new DerivedClass();
            c.Print();
            c.SayHello();
        }

        public override void Print()
        {
            Console.WriteLine("This is derived class");
        }
    }
}