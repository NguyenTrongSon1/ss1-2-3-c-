﻿using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int age;
            double salary;
            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: {0},Age: {1}, Salary: {2}", userName, age, salary);
            Console.WriteLine("Hello World!");
        }
    }
}
