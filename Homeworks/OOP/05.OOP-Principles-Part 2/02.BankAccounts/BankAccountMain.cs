/*
Problem 2. Bank accounts

A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/

namespace BankAccounts
{
    using System;

    public class BankAccountMain
    {
        public static void Main()
        {
            Bank bank = new Bank("GoshoBank");

            bank.AddAccount(new MortgageAccount(new IndividualCustomer("Stamat"), 2000.0m, 18m));
            bank.AddAccount(new DepositAccount(new CompanyCustomer("Pesho Ltd.", "Pesho"), 7500.0m, 12m));
            bank.AddAccount(new LoanAccount(new CompanyCustomer("Alex Ltd.", "Alex"), 5000.0m, 12m));
            bank.AddAccount(new MortgageAccount(new IndividualCustomer("Osama"), 5000.0m, 18m));
            bank.AddAccount(new DepositAccount(new CompanyCustomer("Ivancho Ltd.", "Ivan"), 10000.0m, 12m));
            bank.AddAccount(new LoanAccount(new IndividualCustomer("Kiril"), 1500.0m, 24m));

            Console.WriteLine(bank.Name);
            Console.WriteLine(bank);

            IndividualCustomer customer = new IndividualCustomer("Pencho");

            DepositAccount depositAcc = new DepositAccount(customer, 7000.0m, 24);

            Console.WriteLine(depositAcc.ToString());

            depositAcc.Deposit(1500.0m);

            Console.WriteLine("Deposit account after deposit money: {0:C}",depositAcc.Balance);

            Console.WriteLine("Interes: {0:C}", depositAcc.CalculateInterest(24));

            depositAcc.WithdrawAmount(300);

            Console.WriteLine("Deposit account after withdraw: {0:C}", depositAcc.Balance);
        }
    }
}
