using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\windows\\Myfile.txt";
            bool found = true;
            if(found)
            {
                Console.WriteLine("File path: \'" + path + "\'");
            }
            else
            {
                Console.WriteLine("File Not Found!\a");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
