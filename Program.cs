// See https://aka.ms/new-console-template for more information
using System;
   

    Console.WriteLine("Welcome to the Basic Calculator!");
    
    Console.WriteLine("");
    
    Console.WriteLine("Enter number 1");
    Console.WriteLine("");
    
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Enter number 2");
    Console.WriteLine("");

double num2 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("+, -, *, /");
    Console.WriteLine("");
double result = 0;

    string sign = Console.ReadLine();

    switch (sign)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine(result);
            Console.WriteLine("");
        break;

        case "-":
            result = num1 - num2;
           Console.WriteLine(result);
           Console.WriteLine("");
        break;

        case "*":
            result = num1 * num2;
            Console.WriteLine(result);
            Console.WriteLine("");
        break;

        case "/":
            result = num1 / num2;
            Console.WriteLine(result);
            Console.WriteLine("");
        break;
        
    }


        

