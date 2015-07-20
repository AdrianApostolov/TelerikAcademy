namespace School
{
    using System;

    public class StudentTest
    {
        public static void Main()
        {
            var firstStudent = new Student("Pesho", "Motikarq", new DateTime(1990, 12, 28));
            Console.WriteLine(firstStudent);

            var secondStudent = new Student("Gosho", "Teslata", new DateTime(1945, 05, 25));
            Console.WriteLine(secondStudent);

            bool isSecondOlder = secondStudent.IsOlderThan(firstStudent);

            Console.WriteLine("{0} {1} is older than {2} {3}: {4}",
                secondStudent.FirstName, secondStudent.LastName, firstStudent.FirstName, firstStudent.LastName, isSecondOlder);
        }
    }
}
