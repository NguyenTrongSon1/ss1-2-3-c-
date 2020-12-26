using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Date is { 0:dddMMMdd,YYYY}", date);
            Console.WriteLine("Time is {0:hh:mmtt}", date);
            Console.WriteLine("24 hour time is {0:HH:mm}", date);
            Console.WriteLine("Time with seconds : {0:HH:mm:ss tt}", date);
            Console.WriteLine("Day of month : {0:m}", date);
            Console.WriteLine("year : {0:YYYY}", date);
            Console.WriteLine("Hello World!");
        }
    }
}
