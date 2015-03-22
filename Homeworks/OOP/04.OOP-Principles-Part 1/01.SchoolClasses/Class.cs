namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string identifier;
        private List<Student> students;
        private List<Teacher> teachers;
        private string comment;

        public Class(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.Identifier = identifier;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public Class (string identifier, List<Student> students, List<Teacher> teachers, string comment)
            : this(identifier, students, teachers)
        {
            this.Comment = comment;
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            private set
            {
                if (this.identifier == null)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Class identifier must not be null or empty");
                    }

                    this.identifier = value;
                }
            }
        }

        public List<Student> Student
        {
            get
            {
                return new List<Student>(this.students);
            }

            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("Student cannnot be negative or zero");
                }

                this.students = value;
            }
        }

        public List<Teacher> Teacher
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }

            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("Teacher cannnot be negative or zero");
                }

                this.teachers = value;
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
    }
}
