/*
Problem 3. Animal hierarchy

Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/ 

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AnimalHierarchyMain
    {
        private static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            Dog[] dogs = {
                             new Dog("Balkan", 5, Gender.Male),
                             new Dog("Pesko", 3, Gender.Male),
                             new Dog("Koicho", 2, Gender.Male),
                             new Dog("Sherry", 1, Gender.Female)
                         };

            Cat[] cats = {
                             new Cat("Tomy", 7, Gender.Male),
                             new Cat("Milenco", 2, Gender.Male),
                             new Cat("Spaska", 3, Gender.Female),
                             new Cat("Kalinka", 5, Gender.Female)
                             
                         };

            Frog[] frogs = {
                               new Frog("Stamat", 1, Gender.Male),
                               new Frog("Pesho", 3, Gender.Male),
                               new Frog("Penka", 2, Gender.Female),
                               new Frog("Kapka", 7, Gender.Female)
                           };

            Kitten[] kittens = {
                                   new Kitten("Minka", 2),
                                   new Kitten("Nadka", 4),
                                   new Kitten("Milena", 11),
                                   new Kitten("Sashka", 7)
                               };

            Tomcat[] tomcats = {
                                   new Tomcat("Tom", 9),
                                   new Tomcat("Sam", 5),
                                   new Tomcat("Bill", 3),
                                   new Tomcat("Jhony", 12),
                               };
                        
            double dogsAverageAge = Animal.CalculateAverageAge(dogs);
            double catsAverageAge = Animal.CalculateAverageAge(cats);
            double frogsAverageAge = Animal.CalculateAverageAge(frogs);
            double kittensAverageAge = Animal.CalculateAverageAge(kittens);
            double tomcatsAverageAge = Animal.CalculateAverageAge(tomcats);

            sb.AppendLine("Cats average age: " + catsAverageAge)
                .AppendLine("Dogs average age: " + dogsAverageAge)
                .AppendLine("Frogs average age: " + frogsAverageAge)
                .AppendLine("Kittens average age: " + kittensAverageAge)
                .AppendLine("Tomcats average age: " + tomcatsAverageAge);

            Console.WriteLine(sb);
        }
    }
}
