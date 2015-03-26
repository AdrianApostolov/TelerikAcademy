namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Bank
    {
        private string name;
        private ICollection<Account> accounts;

        public Bank(string name)
        {
            this.Name = name;
            this.Accounts = new List<Account>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public ICollection<Account> Accounts
        {
            get
            {
                return this.accounts;
            }

            private set
            {
                this.accounts = value;
            }
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var account in this.accounts)
            {
                result.AppendLine(account.ToString());
            }

            return result.ToString();
        }
    }
}
