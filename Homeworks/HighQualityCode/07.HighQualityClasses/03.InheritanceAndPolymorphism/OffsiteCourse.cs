namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private const string InvalidTownNameExceptionMessage = "Town name cannot be null or empty.";
        private string town;

        public OffsiteCourse(string name, string teacherName, ICollection<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidTownNameExceptionMessage);
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            result.AppendLine("Town = " + this.Town);

            return result.ToString();
        }
    }
}
