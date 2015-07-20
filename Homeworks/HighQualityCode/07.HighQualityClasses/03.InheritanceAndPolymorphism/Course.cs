namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        private const string InvalidCourseNameExceptionMessage = "Course name cannot be null or empty.";
        private const string InvalidTeacherNameExceptionMessage = "Teacher name cannot be null or empty.";
        private const string InvalidStudentNameExceptionMessage = "Student name cannot be null or empty.";
        private string name;
        private string teacherName;
        private ICollection<string> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<string>();
        }

        public Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;   
        }

        public Course(string name, string teacherName, ICollection<string> students)
            : this(name, teacherName)
        {
            if (students != null)
            {
                foreach (var student in students)
                {
                    this.students.Add(student);
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidCourseNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidTeacherNameExceptionMessage);
                }

                this.teacherName = value;
            }
        }

        public ICollection<string> Students 
        {
            get
            {
                return new List<string>(this.students);
            } 
        }

        public void AddStudets(params string[] students)
        {
            foreach (var student in students)
            {
                if (string.IsNullOrEmpty(student))
                {
                    throw new ArgumentException(InvalidStudentNameExceptionMessage);
                }

                this.students.Add(student);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0} {{ Name = {1}", this.GetType().Name, this.Name);
            result.AppendFormat("; Students = {0}", this.GetStudentsAsString());
            result.Append(" }");

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
