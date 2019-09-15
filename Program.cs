using System;

namespace delegates
{
    class Program
    {
        delegate  int Operation (int a, int b );
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Operation operation = Sum;
            var sum = operation(a,b);

             operation = Subtraction;
            var sub = operation(a,b);
            
             operation = Multiplication;
            var mult = operation(a,b);
            
             operation = Div;
            var div = operation(a,b);

            operation = (x,y) => x + x - y * x;
            var anon = operation(a,b);

            System.Console.WriteLine($"{a} + {b} = {sum}");
            System.Console.WriteLine($"{a} - {b} = {sub}");
            System.Console.WriteLine($"{a} * {b} = {mult}");
            System.Console.WriteLine($"{a} / {b} = {div}");
            //Wiith Lambda and anonymous
            System.Console.WriteLine($"{a} + {a} - {b} * {a} = {anon}");
        }

        static int Sum(int a, int b) => a + b;
        static int Subtraction(int a, int b) => a - b;
        static int Multiplication(int a, int b) => a * b;
        static int Div(int a, int b) => a / b;
    }
}
