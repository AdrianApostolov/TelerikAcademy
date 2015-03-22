namespace OperationWithStudents
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private byte age;

        public Student(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be empty!");
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
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be negative or zero");
                }

                this.age = value;
            }
        }

        public override string ToString() 
        {
            return this.firstName + " " + this.lastName + " is " + this.age + " years old";
        }
    }
}
