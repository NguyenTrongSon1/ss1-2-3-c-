using System;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftVal = 50;
            int rightVal = 100;
            Console.WriteLine("Equal: " + (leftVal == rightVal));
            Console.WriteLine("No Equal: " + (leftVal != rightVal));
            Console.WriteLine("Greater: " + (leftVal > rightVal));
            Console.WriteLine("Lesser: " + (leftVal < rightVal));
            Console.WriteLine("Greater or Equal: " + (leftVal >= rightVal));
            Console.WriteLine("Lesser or Equal: " + (leftVal <= rightVal)); 
            Console.WriteLine("Hello World!");
        }
    }
}
