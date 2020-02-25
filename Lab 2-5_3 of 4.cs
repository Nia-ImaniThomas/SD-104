using System;

namespace Lab_2_5_3_of_4
{
    class Program
    {
        static void Main(string[] args)
        {/*3. Write a C# program to print the output of multiplication of three numbers which
              will be entered by the user*/
            int number1; 
            int number2;
            int number3;

            Console.WriteLine("Enter a value for the first number: 3");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number: 6");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the third number: 9");
            number3 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2 * number3;
            Console.WriteLine("The answer is: 162");
            Console.WriteLine(result);
        }
    }
}
