namespace BankAccounts
{
    using System;

    public class LoanAccount : Account
    {
        private const int NoInterestInitialPeriodForCompany = 2;
        private const int NoInterestInitialPeriodForIndividual = 3;

        public LoanAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer is CompanyCustomer)
            {
                if (months <= NoInterestInitialPeriodForCompany)
                {
                    return 0;
                }

                return this.MonthlyInterestRate * (months - NoInterestInitialPeriodForCompany);
            }
            else if (this.Customer is IndividualCustomer)
            {
                if (months <= NoInterestInitialPeriodForIndividual)
                {
                    return 0;
                }

                return this.MonthlyInterestRate * (months - NoInterestInitialPeriodForIndividual);
            }

            return 0;
        }

        public override void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override string ToString()
        {
            return String.Format("Loan account {0} - {1:C}", this.Customer.Name, this.Balance);
        }
    }
}
