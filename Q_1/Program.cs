using System;

namespace program
{
    class MainClass{
        public static void Main(string[] args)
        {
            // Console.WriteLine("hello q1: ");
            Console.WriteLine("Please enter the numerator ? ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Please enter the denominator ? ");
            string num2 = Console.ReadLine();

            int numerator = Int32.Parse(num1);

            int denominator = Int32.Parse(num2);

            int div = numerator/denominator;
            int reminder = numerator % denominator;

            Console.WriteLine("Integer division result = "+div+" with a reminder "+reminder);

            float divsion = (float) numerator/denominator;

            Console.WriteLine("Floating point division result = "+divsion);

            // mixed fraction 
            Console.WriteLine("The result as a mixed fraction is "+div+" "+reminder+"/"+denominator);


          
        }
    }
}