/*
Problem 1. School classes

We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/ 

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class SchoolClassesMain
    {
        public static void Main()
        {
            School school = new School("NPMG");

            Discipline mathematics = new Discipline("Matematics", 20, 50);
            Discipline geography = new Discipline("Geography", 15, 20);
            Discipline biology = new Discipline("Biology", 20, 30);

            Teacher firstTeacher = new Teacher("Petar Nedevski", new List<Discipline> {mathematics});
            Teacher secodTeacher = new Teacher("Dimo Padalski", new List<Discipline> { geography });
            Teacher thirdTeacher = new Teacher("Tatqna Bobeva", new List<Discipline> { biology });

            Student firstStudent = new Student("Georgi Kolev", "7", "This is the best school!");
            Student secondStudent = new Student("Elena Dragusheva", "11");
            Student thirdStudent = new Student("Valeriq Dimova", "6", "My class is perfect!");

            Class schoolClass = new Class("Class Z",new List<Student> {firstStudent, secondStudent, thirdStudent}, 
                new List<Teacher> {firstTeacher, secodTeacher, thirdTeacher});

            school.AddClass(schoolClass);

            Console.Write(school.ToString());
        }
    }
}
