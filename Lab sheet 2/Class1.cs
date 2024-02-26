using System;

namespace BankAccountClass
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(int accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount should be greater than zero.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(12345678);
            Console.WriteLine("Account Number: " + myAccount.AccountNumber);
            Console.WriteLine("Initial Balance: " + myAccount.Balance);

            Console.WriteLine("Enter deposit amount: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            myAccount.Deposit(depositAmount);

            Console.WriteLine("New Balance: " + myAccount.Balance);

            Console.ReadKey();
        }
    }
}