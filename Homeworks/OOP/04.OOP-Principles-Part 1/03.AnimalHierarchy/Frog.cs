namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override string ProduceSound()
        {
            return "Croak, croak!";
        }
    }
}
