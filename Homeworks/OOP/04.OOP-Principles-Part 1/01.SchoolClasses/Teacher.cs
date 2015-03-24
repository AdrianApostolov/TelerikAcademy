namespace SchoolClasses
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Teacher : Person, IComment
    {
        private List<Discipline> disciplines;
        private string comment;

        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }


        public Teacher(string name, List<Discipline> disciplines, string comment) 
            : this (name, disciplines)
        {
            this.Comment = comment;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
            }

            private set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("Disciplines cannnot be negative or zero");
                }

                this.disciplines = value;    
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

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            foreach (var discipline in this.Disciplines)
            {
                sb.AppendLine(discipline.ToString());
            }
            return sb.ToString();
        }
    }
}
