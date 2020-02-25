using System;

namespace Lab_2_5_1_of_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2-4_1 of 4");
            /*1. Write a C# program to print on screen the output of adding, subtracting,
            multiplying and dividing of two numbers which will be entered by the user.*/
            int number1; //input one
            int number2; //input two

            Console.WriteLine("Enter a value for the first number: 2");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value fpr the second number: 7");
            number2 = Convert.ToInt32(Console.ReadLine());

            //adding
            int result = number1 + number2;
            Console.WriteLine("The answer is: 9");
            Console.WriteLine(result);

            //subtracting 
            result = number1 - number2;
            Console.WriteLine("The answer is: -5");
            Console.WriteLine(result);

            //multiplying
            result = number1 * number2;
            Console.WriteLine("The answer is: 14");
            Console.WriteLine(result);

            //divining
            double results2 = (double)number1 / (double)number2;
            double results3 = number1 % number2; //left over after division
            Console.WriteLine("The answer is:");
            Console.WriteLine(results2); //To print the results as a double
            Console.WriteLine(results3);

        }
    }

}
