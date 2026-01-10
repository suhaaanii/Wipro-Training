using System;

namespace CoreBanking
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accNo, double balance)
            : base(accNo, balance)
        {
        }

        public void AddInterest()
        {
            Balance += Balance * 0.05;
            Console.WriteLine("Interest added to Savings Account");
        }
    }
}
