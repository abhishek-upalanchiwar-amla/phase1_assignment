using System;
using System.Net.Http.Headers;

class Program
{
    public void Abhishek()
    {
        Console.WriteLine("we are creating the calculator");

        Console.WriteLine("enter the first number");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter the second number");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter the operation that you want to perform number");
        string op = Console.ReadLine();

        double res = 0;

        switch (op)
        {
            case "+":
                res = num1 + num2;
                break;

            case "-":
                res = num1 - num2;
                break;

            case "*":
                res = num1 * num2;
                break;

            case "/":
                res = num1 / num2;
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;

        }

        Console.WriteLine(res);



    }
}
