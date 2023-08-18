using System;
using System.Runtime.InteropServices;

delegate int MathOperation(int a, int b);

class program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        if (b != 0)
            return a / b;
        else
            throw new DivideByZeroException("Cannot divide by zero.");
    }

    static void PerformOperation(MathOperation operation, int a, int b)
    {
        int result = operation(a, b);
        Console.WriteLine("Result: " + result);
    }

    static void Main(string[] args)
    {
        MathOperation add = new MathOperation(Add);
        MathOperation subtract = new MathOperation(Subtract);
        MathOperation multiply = new MathOperation(Multiply);
        MathOperation divide = new MathOperation(Divide);


        int a = 10;
        int b = 5;

       PerformOperation(add, a, b);
       PerformOperation(subtract, a, b);
       PerformOperation(multiply, a, b);
       PerformOperation(divide, a, b);
    }
}
