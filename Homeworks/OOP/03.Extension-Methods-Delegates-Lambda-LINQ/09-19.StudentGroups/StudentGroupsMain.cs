/*
 Problem 9. Student groups
   Create a class `Student` with properties `FirstName`, `LastName`, `FN`, `Tel`, `Email`, `Marks` (a List<int>), `GroupNumber`.
   Create a `List<Student>` with sample students. Select only the students that are from group number 2.
   Use LINQ query. Order the students by FirstName.
 
 Problem 10. Student groups extensions
   Implement the previous using the same query expressed with extension methods.
 
 Problem 11. Extract students by email
   Extract all students that have email in `abv.bg`.
   Use `string` methods and LINQ.
 
 Problem 12. Extract students by phone
   Extract all students with phones in Sofia. Use LINQ.
 
 Problem 13. Extract students by marks
   Select all students that have at least one mark `Excellent` (`6`) into a new anonymous class that has properties – `FullName` and     `Marks`. Use LINQ.

 Problem 14. Extract students with two marks
   Write down a similar program that extracts the students with exactly two marks "`2`". Use extension methods.
 
 Problem 15. Extract marks 
   Extract all `Marks` of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
 
 Problem 16.* Groups
   Create a class `Group` with properties `GroupNumber` and `DepartmentName`.
   Introduce a property `Group` in the `Student` class.
   Extract all students from "Mathematics" department.
   Use the `Join` operator.
 
 Problem 18. Grouped by GroupName
   Create a program that extracts all students grouped by `GroupName` and then prints them to the console. Use LINQ.
 Problem 19. Grouped by GroupName extensions
   Rewrite the previous using extension methods.
 */

namespace StudentGroups
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    class StudentGroupsMain
    {
        static void Main()
        {
            List<Student> students = new List<Student> 
           {
               new Student("Stamat", "Penchev", "7024268", "02/9730177", "stamat@yahoo.com", 1, new List<int>{5, 6,}),
               new Student("Pesho", "Ivanov", "2024068", "02/9735001", "pesho@abv.bg", 2, new List<int>{2, 3, 6,}),
               new Student("Gosho", "Dimitrov", "3054769", "052/9920177", "gosho@gmail.com", 1, new List<int>{6, 5, 6, 6}),
               new Student("Balkan", "Georgiev", "2655268", "02/9332242", "balkan@mail.bg", 2, new List<int>{2, 2, 3, 3}), 
               new Student("Gospodin", "Gospodinov", "5353068", "032/5440000", "gospodin@gmail.com", 3, new List<int>{4, 5, 4, 4})
           };

           //DisplayResult(SecondGroupLINQ(students));
           //DisplayResult(SecondGroupExtensionMethods(students));
           //DisplayResult(ExtractStudentsByEmail(students));
           //DisplayResult(ExtractStudentsByTel(students));
           //DisplayResult(ExtractStudentsByExcellentMark(students));
           //DisplayResult(ExtractStudentsByTwoMark(students));
           //DisplayResult(ExtractStudentsMarksByEnrollment(students));
           //DisplayResult(ExtractStudentsByDepartmentName(students));
           //DisplayResult(GroupStudentsByGroupNumberLINQ(students));
           //DisplayResult(GroupStudentsByGroupNumberExpressions(students));
        }

        //Problem 9
        public static List<Student> SecondGroupLINQ(List<Student> students)
        {
            var selectedStudents = from student in students
                                   where student.GroupNumber == 2
                                   orderby student.FirstName
                                   select student;

            return selectedStudents.ToList<Student>();
        }

        //problem 10
        public static List<Student> SecondGroupExtensionMethods(List<Student> students)
        {
            return students
                .Where(s => s.GroupNumber == 2)
                .OrderBy(s => s.FirstName)
                .ToList<Student>();
        }

        //problem 11
        public static List<Student> ExtractStudentsByEmail(List<Student> students)
        {
            var selectedStudents = from student in students
                                   where student.Email.Contains("gmail.com")
                                   select student;

            return selectedStudents.ToList<Student>();
        }

        //problem 12
        public static List<Student> ExtractStudentsByTel(List<Student> students)
        {
            var selectedStudents = from student in students
                                   where student.Tel.Contains("02")
                                   select student;

            return selectedStudents.ToList<Student>();
        }

        //problem 13
        public static List<dynamic> ExtractStudentsByExcellentMark(List<Student> students)
        {
            var selectedStudents = from student in students
                                   where student.Marks.Contains(6)
                                   select new
                                   {
                                       FullName = student.FirstName + " " + student.LastName,
                                       Marks = string.Join(", ", student.Marks)
                                   };

            return selectedStudents.ToList<dynamic>();
        }

        //problem 14

        public static List<dynamic> ExtractStudentsByTwoMark(List<Student> students)
        {
            var selectedStudents = students
                .Where(s => (s.Marks.Count == 2))
                .Select(s => new
                {
                    FullName = s.FirstName + " " + s.LastName,
                    Marks = string.Join(", ", s.Marks)
                });

            return selectedStudents.ToList<dynamic>();
        }

        //problem 15
        public static List<int> ExtractStudentsMarksByEnrollment(List<Student> students)
        {
            var selectedMarks = students
                .Where(s => s.FN.Substring(4, 2) == "06")
                .Select(s => s.Marks);

            var marks = new List<int>();

            foreach (var mark in selectedMarks)
            {
                marks.AddRange(mark);
            }

            return marks.ToList();
        }

        //problem 16
        public static List<Student> ExtractStudentsByDepartmentName(List<Student> students)
        {
            var groups = new List<Group>
			             {
							new Group(1, "Biology"),
							new Group(2, "Mathematics"),
							new Group(3, "Chemistry"),
			             };

            var selectedStudents =
                from student in students
                join gr in groups on student.GroupNumber equals gr.GroupNumber
                where gr.DepartmentName == "Mathematics"
                select student;

            return selectedStudents.ToList<Student>();
        }

        //problem 18
        public static Dictionary<int, string> GroupStudentsByGroupNumberLINQ(List<Student> students)
        {
            var groupedStudents = from student in students
                                  group student by student.GroupNumber;

            var grouped = new Dictionary<int, string>();

            foreach (var group in groupedStudents)
            {
                var currentGorup = new List<string>();

                foreach (var student in group)
                {
                    currentGorup.Add(student.FirstName + " " + student.LastName);
                }

                grouped.Add(group.Key, string.Join(", ", currentGorup));
            }

            return grouped;
        }

        //problem 19
        public static Dictionary<int, string> GroupStudentsByGroupNumberExpressions(List<Student> students)
        {
            var groupedStudents = students.GroupBy(s => s.GroupNumber);

            var grouped = new Dictionary<int, string>();

            foreach (var group in groupedStudents)
            {
                var currentGorup = new List<string>();

                foreach (var student in group)
                {
                    currentGorup.Add(student.FirstName + " " + student.LastName);
                }

                grouped.Add(group.Key, string.Join(", ", currentGorup));
            }

            return grouped;
        }

        //Helper methods
        public static void DisplayResult<T>(List<T> studets)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < studets.Count; i++)
            {
                sb.Append(studets[i].ToString());
                sb.AppendLine();
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        public static void DisplayResult(List<int> studets)
        {
            List<int> marks = new List<int>();

            for (int i = 0; i < studets.Count; i++)
            {
                marks.Add(studets[i]);
            }

            Console.WriteLine(string.Join(", ", marks));
        }

        public static void DisplayResult(Dictionary<int, string> studets)
        {
            foreach (var studet in studets)
            {
                Console.WriteLine("Group {0}", studet.Key + "-" + studet.Value);
            }
        }
    }
}
