namespace SchoolClasses
{
    using System;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures ;
        private int numberOfExercises;
        private string comment;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment) 
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get 
            { 
                return name; 
            }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                name = value;
            }
        }

        public int NumberOfLectures
        {
            get 
            { 
                return numberOfLectures; 
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of lectures cannot be negative.");
                }

                numberOfLectures = value; 
            }
        }

        public int NumberOfExercises
        {
            get 
            { 
                return numberOfExercises; 
            }

            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of exercises cannot be negative.");
                }

                numberOfExercises = value; 
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
