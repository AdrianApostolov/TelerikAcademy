namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty;");
                }

                firstName = value; 
            }
        }

        public string LastName
        {
            get 
            {
                return this.lastName;
            }

            private set 
            { 
                 if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty;");
                }

                lastName = value; 
            }
        }
    }
}
