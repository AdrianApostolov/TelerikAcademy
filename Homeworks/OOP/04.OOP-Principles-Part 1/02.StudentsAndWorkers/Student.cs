namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string secondName)
            : base(firstName, secondName)
        {

        }

        public Student(string firstName, string secondName, int grade)
            : base(firstName, secondName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Student grade have to be between 1 and 12!");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} from {2} grade", this.FirstName, this.LastName, this.Grade);
        }
    }
}
