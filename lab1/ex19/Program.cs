using System;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 5;
            int two = 10;
            Console.WriteLine("Value = " + one);
            one += 4;
            Console.WriteLine("Value +=4 " + one);
            one -= 8;
            Console.WriteLine("Value -=8 " + one);
            one *= 7;
            Console.WriteLine("Value *=7 " + one);
            one /= 2;
            Console.WriteLine("Value /=2 " + one);
            Console.WriteLine("Value1 == value2 : {0}", (one == two));
           
        }
    }
}
