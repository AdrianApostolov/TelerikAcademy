namespace BankAccounts
{
    using System;

    public class CompanyCustomer : Customer
    {
        private string personForContact;

        public CompanyCustomer(string name, string personForContact)
            : base(name)
        {
            this.PersonForContact = personForContact;
        }

        public string PersonForContact
        {
            get
            {
                return this.personForContact;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Person for contact cannot be null or empty.");
                }

                this.personForContact = value;
            }
        }
    }
}
