using System;

namespace LambdaPractice
{
    public delegate int AddNumbers(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers del = (a, b) => a + b;
            var data = new ProcessData();
            data.Process(2, 3, del);
            Console.WriteLine("Added");
        }
    }
}
