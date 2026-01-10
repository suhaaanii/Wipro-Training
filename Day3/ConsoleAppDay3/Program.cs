
using System;
using CoreBanking;

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, 10000);
        sa.AddInterest();
        sa.ShowAccount();

        Console.WriteLine();

        CurrentAccount ca = new CurrentAccount(102, 20000);
        ca.DeductCharges();
        ca.ShowAccount();

        // internal member accessible (same assembly)
        Console.WriteLine("Branch Code: " + sa.BranchCode);
    }
}
