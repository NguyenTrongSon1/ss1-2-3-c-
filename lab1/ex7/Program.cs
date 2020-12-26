using System;

namespace ex7
{
    class Program { 
    
        static void Main(string[] args)
        {
            int number, result;
            number = 5;
            result = 100 * number;
            Console.WriteLine("Result is {0} when 100 is multipliedby {1}", result, number);
            result = 150 / number;
            Console.WriteLine("result is {0} when 150 is dividedby {1}", result, number);
            Console.WriteLine("Hello World!");
        }
    }
}
