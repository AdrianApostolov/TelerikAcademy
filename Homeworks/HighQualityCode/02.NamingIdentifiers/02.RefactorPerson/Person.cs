namespace RefactorPerson
{
    public class Person
    {

        public Person() { }

        public Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} | Age: {1} | Sex: {2}", this.Name, this.Age, this.Gender);
        }
    }
}
