using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Calculatorrr
{
    class Program
    {



        static void Main(string[] args)
        {

            Welcome();

        }

        static void Welcome()
        {
            double number = 0;
            Console.WriteLine("Welcome to the calculator! Enter the first number");
            try
            {
                number = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                Welcome();
            }
            Console.WriteLine("Choose an operation to do: \n+ to add \n- to subtract \n/ to divide \n* to multiply \n! for factorial \n^ for exponentiation");
            string operation = (Console.ReadLine());
            switch (operation)
            {
                case "+":
                    Plus(ref number);
                    break;
                case "-":
                    Minus(ref number);
                    break;
                case "/":
                    Division(ref number);
                    break;
                case "*":
                    Multiply(ref number);
                    break;
                case "!":
                    Facto(ref number);
                    break;
                case "^":
                    Exponenta(ref number);
                    break;
                default:
                    Console.WriteLine("choose a correct operation please");
                    Welcome();
                    break;

            }

        }

        static void Plus(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter the second number");
            try
            {
                number2 = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                Plus(ref number);
            }
            double plusresult = number + number2;
            Console.WriteLine("{0} + {1} = {2}", number, number2, plusresult);
            Welcome();
        }
        static void Minus(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter the second number");
            try
            {
                number2 = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                Minus(ref number);
            }
            double minusresult = number - number2;
            Console.WriteLine("{0} - {1} = {2}", number, number2, minusresult);
            Welcome();
        }
        static void Division(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter the second number");
            try
            {
                number2 = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                Division(ref number);
            }
            double divresult = number / number2;
            Console.WriteLine("{0} / {1} = {2}", number, number2, divresult);
            Welcome();
        }
        static void Multiply(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter the second number");
            try
            {
                number2 = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                Multiply(ref number);
            }
            double multresult = number * number2;
            Console.WriteLine("{0} * {1} = {2}", number, number2, multresult);
            Welcome();
        }
        static void Exponenta(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter the second number");
            try
            {
                number2 = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                Exponenta(ref number);
            }
            double expresult = Math.Pow(number, number2);
            Console.WriteLine("{0} ^ {1} = {2}", number, number2, expresult);
            Welcome();
        }
        static void Facto(ref double number)
        {
            double i = 0;
            double fact = 0;

            if (number < 0)
            {
                Console.WriteLine("The number should be integer and positive");
                FactoRepeat();
            }
            bool isint = number % 1 == 0;
            if (isint == false)
            {
                Console.WriteLine("The number should be integer and positive");
                FactoRepeat();
            }

            fact = number;
            if (number > 170)
            {
                Console.WriteLine("That's a big ass factorial");
            }

            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is: " + fact);
            Welcome();
        }
        static void FactoRepeat()
        {
            double i = 0;
            double fact = 0;
            double number = 0;

            Console.WriteLine("Enter the number");
            try
            {
                number = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                FactoRepeat();
            }

        

        bool isint = number % 1 == 0;
                if (isint == false)
                {
                    Console.WriteLine("The number should be integer and positive");
                    FactoRepeat();

                }
                if (number< 0)
                {
                    Console.WriteLine("The number should be integer and positive");
                    FactoRepeat();
                }



            fact = number;
            if (number >= 170)
            {
                Console.WriteLine("That's a big ass factorial");
            }

            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is: " + fact);
            Welcome();
        }
    }
    }

