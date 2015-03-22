/*
Problem 3. First before last

Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.

Problem 4. Age range

Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 
Problem 5. Order students

Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
*/

namespace OperationWithStudents
{
    using System;
    using System.Linq;
    using System.Text;

    public class StudentsMain
    {
        public static void Main()
        {
            Student[] arrayOfStudents =
            {
                new Student("Mitko", "Ivanov", 12),
                new Student("Atanas", "Dimitrov", 22),
                new Student("Georgi", "Atanassov", 50),
                new Student("Stamat", "Georgiev", 19),
                new Student("Nikolai", "Todorov", 28),
                new Student("Gosho", "Ivanov", 24),
                new Student("Dimitar", "Peshev", 18),
                new Student("Atanas", "Andreev", 28)
            };

            Console.WriteLine("All students:\n");
            DisplayResult(arrayOfStudents);

            Console.WriteLine("\nStudents whose first name is before their last alphabetically:\n");
            DisplayResult(FirstBeforeLast(arrayOfStudents));

            Console.WriteLine("\nStudents whose age is between 18 and 24:\n");
            DisplayResult(AgeRange(arrayOfStudents, 18, 24));

            Console.WriteLine("\nStudents sorted by first and then last name using lambda expressions:\n");
            DisplayResult(SortWithExtensionMethods(arrayOfStudents));

            Console.WriteLine("\nStudents sorted by first and then last name using LINQ:\n");
            DisplayResult(SortWithLINQ(arrayOfStudents));
        }

        //Problem 3
        public static Student[] FirstBeforeLast(Student[] students)
        {
            var sortedStudets = from student in students
                                where student.FirstName.CompareTo(student.LastName) < 0
                                select student;

            return sortedStudets.ToArray();
        }

        //Problem 4
        public static Student[] AgeRange(Student[] students, byte minAge, byte maxAge)
        {
            var sortedStudent = from student in students
                                where student.Age <= maxAge && student.Age >= minAge
                                select student;

            return sortedStudent.ToArray();
        }

        //Problem 5
        public static Student[] SortWithExtensionMethods(Student[] students)
        {
            return students
                 .OrderByDescending(s => s.FirstName)
                 .ThenByDescending(s => s.LastName)
                 .ToArray();
        }

        public static Student[] SortWithLINQ(Student[] students)
        {
            var sortedStudent = from student in students
                                orderby student.FirstName descending, student.LastName descending
                                select student;

            return sortedStudent.ToArray();
        }
        //Helper method
        public static void DisplayResult(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
