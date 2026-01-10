using System;

namespace CoreBanking
{
    public class BankAccount
    {
        public int AccountNumber;
        protected double Balance;     // for derived classes
        internal string BranchCode;   // same assembly only

        public BankAccount(int accNo, double balance)
        {
            AccountNumber = accNo;
            Balance = balance;
            BranchCode = "BR001";
        }

        public void ShowAccount()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
