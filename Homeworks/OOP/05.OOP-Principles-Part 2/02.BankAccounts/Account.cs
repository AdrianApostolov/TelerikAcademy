namespace BankAccounts
{
    using System;
    using System.Text;

    public abstract class Account :  ICalculateInterest, IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal monthlyInterestRate;

        protected Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                this.balance = value;
            }
        }

        public decimal MonthlyInterestRate
        {
            get
            {
                return this.monthlyInterestRate;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Montly interest rate cannot be negative.");
                }

                this.monthlyInterestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int months);

        public abstract void Deposit(decimal sum);

        public override string ToString()
        {
            var sb = new StringBuilder();

              sb.AppendLine("Balance: " + this.Balance)
                .AppendLine("Monthly interest rate: " + this.MonthlyInterestRate)
                .Append("Customer: " + Customer.ToString());

            return sb.ToString();
        }
    }
}
