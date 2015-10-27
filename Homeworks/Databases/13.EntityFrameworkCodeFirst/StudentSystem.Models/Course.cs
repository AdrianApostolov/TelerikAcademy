namespace StudentSystem.Models
{
    using System.Collections.Generic;


    public class Course
    {
        private ICollection<Student> studets;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.studets = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Materials { get; set; }

        public ICollection<Student> Studets
        {
            get { return studets; }
            set { studets = value; }
        }

        public ICollection<Homework> Homeworks
        {
            get { return homeworks; }
            set { homeworks = value; }
        }
    }
}
