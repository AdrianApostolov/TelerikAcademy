namespace StudentSystem.Models
{
    using System.Collections.Generic;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public ICollection<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public ICollection<Homework> Homeworks
        {
            get { return homeworks; }
            set { homeworks = value; }
        }

    }
}
