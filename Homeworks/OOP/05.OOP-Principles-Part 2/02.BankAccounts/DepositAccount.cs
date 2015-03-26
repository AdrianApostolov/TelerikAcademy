namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
            
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return this.MonthlyInterestRate * months;
        }

        public override void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public void WithdrawAmount(decimal ammount)
        {
            if (ammount > this.Balance)
            {
                throw new ArgumentException("The account does not have enough money." + " " + " Balance: " + this.Balance);
            }

            this.Balance -= ammount;
        }

        public override string ToString()
        {
            return String.Format("Deposit account {0} - {1:C}", this.Customer.Name, this.Balance);
        }
    }
}
