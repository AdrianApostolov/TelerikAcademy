namespace SchoolClasses
{
    using System;

    public class Student : Person, IComment
    {
        private string classNumber;
        private string comment;

        public Student(string name, string classNumber)
            : base(name)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }

        public Student(string name, string classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("Class number cannot be negative or zero.");
                }

                this.classNumber = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Studet name: {0}, identifier: {1}, comment: {2}", base.ToString(), this.ClassNumber, this.Comment);
        }
    }
}
