using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            string custName;
            double loanAmount;
            float interest = 0.9F;
            double interestAmount = 0;
            double totalAmount = 0;
            Console.WriteLine("Enter the name of the customer: ");
            custName = Console.ReadLine();
            Console.WriteLine("Enter loan amout: ");
            loanAmount = Convert.ToDouble(Console.ReadLine());
            interestAmount = loanAmount * interest;
            totalAmount = loanAmount * interestAmount;
            Console.WriteLine("\n CustomerName: {0}", custName);
            Console.WriteLine("Loan amount : ${0:#,###.#0}\nInterest rate : {1:0#%}\nInterestAmount : ${2:#,###.#0}", loanAmount, interest, interestAmount);
            Console.WriteLine("Total amount to be paid : ${0:#,###.#0}", totalAmount);

            
        }
    }
}
