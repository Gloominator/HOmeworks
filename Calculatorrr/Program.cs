using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Transactions;

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
            Console.WriteLine("Welcome to the calculator! Enter the first number or type rnd for random");

            string otvetnumber = (Console.ReadLine());
            if (otvetnumber == "rnd") //можно самому ввести число или выбрать рандомное - метод GetRandomNumber
            { 
                number = GetRandomNumber(-1000000, 1000000);
                Console.WriteLine("Your random number is " + number);
                            }
            else
            {
                try
                {
                    number = double.Parse(otvetnumber); // если пользователь ввел число, перевожу string в double
                }
                catch (Exception Bukva)
                {
                    Console.WriteLine("Is this a number?"); // если это не цифра и не rnd - выдаю ошибку что это хз че такое
                    Welcome();
                }
            }
            Operazion(ref number); // метод, который позволяет снова и снова делать операции с ответами предыдущих операций
        }
        static void Operazion(ref double number)
        { Console.WriteLine("Choose an operation to do: \n+ to add \n- to subtract \n/ to divide \n* to multiply \n! for factorial \n^ for exponentiation \nc to clear");
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
                case "c":
                    Welcome(); // при вводе "c" сбросит значения и вернется в начало программы
                    break;
                default:
                    Console.WriteLine("choose a correct operation please");//если ввести фигню возвращает в начало метода
                    Operazion(ref number);
                    break;

            }

        }
        //далее идут методы для каждой из выбранных операций - number это первое введенное число он же ответ в конце операции
        //каждый метод возвращает в operazion - выбрать следующую операцию
        static void Plus(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter a number");
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
            number = plusresult;
            Operazion(ref number);
        }
        static void Minus(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter a number");
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
            number = minusresult;
            Operazion(ref number);
        }
        static void Division(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter a number");
            try
            {
                number2 = double.Parse(Console.ReadLine());
            }
            catch (Exception Bukva)
            {
                Console.WriteLine("Is this a number?");
                Division(ref number);
            }
            if(number2 == 0)
            {
                Console.WriteLine("Can't divide by 0, learn your maths!");
                Welcome();
            }
            double divresult = number / number2;
            Console.WriteLine("{0} / {1} = {2}", number, number2, divresult);
             number = divresult;
            Operazion(ref number);
        }
        static void Multiply(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter a number");
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
             number = multresult;
            Operazion(ref number);
        }
        static void Exponenta(ref double number)
        {

            double number2 = 0;
            Console.WriteLine("Enter a number");
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
            number = expresult;
            Operazion(ref number);
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
            bool isint = number % 1 == 0; //проверяет number на целочисленность
            if (isint == false)
            {
                Console.WriteLine("The number should be integer and positive"); //если number с дробной частью выдает ошибку
                FactoRepeat(); // и ведет в метод где пользователь вводит number заново
            }

            fact = number;
            if (number > 170)
            {
                Console.WriteLine("That's a big ass factorial"); // 170 это по всей видимости граница числа double для факториалов
                Welcome();
            }

            for (i = number - 1; i >= 1; i--) //цикл для вычисления факториала
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} is: {1} ", number, fact);
            number = fact;
            Operazion(ref number);
        }
        static void FactoRepeat()//еще один метод для вычисления факториала если пользователь ввел отрицательный или дробный number
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
                Welcome();
            }

            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} is: {1} ", number , fact);
            number = fact;
            Operazion(ref number);
        }
        static double GetRandomNumber(double minimum, double maximum)//метод для рандомного числа
        {
                        Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
    }

