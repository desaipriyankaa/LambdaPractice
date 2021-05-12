using System;

namespace LambdaPractice
{
    public delegate int AddNumbers(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers del = (a, b) => a + b;
            AddNumbers multdel = (a, b) => a * b;
            var data = new ProcessData();
            data.ProcessA(2, 3, del);
            data.ProcessA(10, 3, multdel);
            Console.WriteLine("Processed");
        }
    }
}
