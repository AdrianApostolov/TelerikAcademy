namespace BankAccounts
{
    using System;

    class MortgageAccount : Account
    {
        private const int InterestInitialPeriodForCompany = 12;
        private const int InterestInitialPeriodForIndividual = 6;

        public MortgageAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
            
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is CompanyCustomer)
            {
                if (months <= InterestInitialPeriodForCompany)
                {
                    return (this.MonthlyInterestRate * months) / 2;
                }

                return this.MonthlyInterestRate * months;
            }
            else if (this.Customer is IndividualCustomer)
            {
                if (months <= InterestInitialPeriodForIndividual)
                {
                    return 0;
                }

                return this.MonthlyInterestRate * months;
            }

            return 0;
        }

        public override void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override string ToString()
        {
            return String.Format("Mortgage account {0} - {1:C}", this.Customer.Name, this.Balance);
        }
    }
}
