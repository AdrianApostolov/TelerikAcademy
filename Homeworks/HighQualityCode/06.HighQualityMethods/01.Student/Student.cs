namespace School
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public Student(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.birthDate = birthDate;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be empty");
                }

                this.lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                DateTime beginningDateTime = new DateTime(1900, 1, 1);
                DateTime endDateTime = DateTime.Now;

                if (beginningDateTime > value || value > endDateTime)
                {
                    throw new ArgumentException(string.Format("Birth date must be between {0} and {1}", beginningDateTime,endDateTime));
                }

                this.birthDate = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            bool isOtherStudetOlder = this.BirthDate.CompareTo(other.BirthDate) < 0;

            return isOtherStudetOlder;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} with birthdate: {2}", this.FirstName, this.LastName, this.BirthDate);
        }
    }
}
