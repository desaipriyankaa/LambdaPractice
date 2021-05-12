using System;

namespace LambdaPractice
{
    public delegate int AddNumbers(int a, int b);
    public delegate int MultiplyNumbers(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers del = (a, b) => a + b;
            var data = new ProcessData();
            data.ProcessA(2, 3, del);
            Console.WriteLine("Added");

            MultiplyNumbers mult = (a, b) => a * b;
            var result = new ProcessData();
            result.ProcessM(4, 5, mult);
            Console.WriteLine("Multiplied");
        }
    }
}
