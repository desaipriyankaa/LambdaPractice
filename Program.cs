using System;

namespace LambdaPractice
{
    public delegate int AddNumbers(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers del = (a, b) => a + b;
            
            Console.WriteLine(del(1,2));
        }
    }
}
