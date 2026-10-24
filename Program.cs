using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace Calculator;

  class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        int result;

        string answer;

        Console.WriteLine("Hello, welcome to my calculator program");
        Console.WriteLine("please enter your first number");

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("please enter your second number");
        num2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("what type of operation would you like to do?");
        Console.WriteLine("please enter a for addition, s for subtraction, m for multiplication or d for division");

        answer = Console.ReadLine();
        if (answer == "a")
        {
            result = num1 + num2;
        }
        else if (answer == "s")
        {
            result = num1 - num2;
        }
        else if (answer == "m")
            result = num1 * num2;
        else
        {
            result = num1 / num2;
        }
        Console.WriteLine($"The result is " + result);
         Console.ReadKey();
    }

    }
 