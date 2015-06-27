namespace RefactorPerson
{
    using System;

    public class PersonTest
    {
        public static void Main()
        {
            Console.Write("Please, enter integer number: ");
            int age = int.Parse(Console.ReadLine());
            Person somePerson = CreatePerson(age);
            Console.WriteLine(somePerson);
        }

        public static Person CreatePerson(int age)
        {

            Person somePerson = new Person();
            somePerson.Age = age;

            if (age % 2 == 0)
            {
                somePerson.Name = "Pesho";
                somePerson.Gender = Gender.Male;
            }
            else
            {
                somePerson.Name = "Penka";
                somePerson.Gender = Gender.Female;
            }

            return somePerson;
        }
    }
}
