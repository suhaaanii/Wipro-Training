using System;

namespace CoreBanking
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(int accNo, double balance)
            : base(accNo, balance)
        {
        }

        public void DeductCharges()
        {
            Balance -= 500;
            Console.WriteLine("Service charges deducted");
        }
    }
}
