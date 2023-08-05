using System;
namespace Program
{
    public class Recursion_Formats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose Factorial is to be found: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Factorial of the number {number} is {Factorial(number)}");
        }
        public static int Factorial(int number)
        {
            if(number==0 ||number==1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number-1);
            }
        }
    }
}