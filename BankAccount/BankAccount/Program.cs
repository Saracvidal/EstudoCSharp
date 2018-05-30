using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountNumber,
                beginningBalance,
                totalItemsCharged,
                totalCreditsApplied,
                limitCreditAllowed;

            Console.WriteLine("Enter the account number: ");
            accountNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the beginning balance: ");
            beginningBalance = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the monthly charged amount of this account: ");
            totalItemsCharged = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total of credits applied to this account in this month: ");
            totalCreditsApplied = Int32.Parse(Console.ReadLine());

            limitCreditAllowed = beginningBalance + totalItemsCharged - totalCreditsApplied;

            Console.WriteLine();
            Console.WriteLine("Account Number: {0}",accountNumber);
            Console.WriteLine("Beginning balance: {0}", beginningBalance);
            Console.WriteLine("Total charged: {0}", totalItemsCharged);
            Console.WriteLine("Total credits: {0}", totalCreditsApplied);
            Console.WriteLine("Credit limit allowed: {0}", limitCreditAllowed);
            Console.WriteLine();


            if (limitCreditAllowed <= 0)
                Console.WriteLine("Credit limit exceeded.");
        }
    }
}
