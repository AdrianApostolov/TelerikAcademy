/*
Problem 2. Students and workers

Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
*/

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StudentsAndWorkersMain
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>();
           
            students.Add(new Student("Ivan", "Ivanv", 3));
            students.Add(new Student("Stoqn", "Dimitrov", 5));
            students.Add(new Student("Georgi", "Ilianov", 3));
            students.Add(new Student("Evgeni", "Kostov", 6));
            students.Add(new Student("Irina", "Stamatova", 12));
            students.Add(new Student("Albena", "Kirilova", 11));
            students.Add(new Student("Milena", "Ivanova", 7));
            students.Add(new Student("Gabriela", "Gospodinova", 8));
            students.Add(new Student("Iliqn", "Dobrev", 9));
            students.Add(new Student("Dimitar", "Sotiroc", 10));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            var orderdStudets = students.OrderBy(s => s.Grade);

            foreach (var student in orderdStudets)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(new string('=', 40));

            //Initialize a list of 10 workers and sort them by money per hour in descending order
            List<Worker> workers = new List<Worker>();
            
            workers.Add(new Worker("Milen", "Kirilov", 500, 8, 5));
            workers.Add(new Worker("Alex", "Georgiec", 600, 7, 5));
            workers.Add(new Worker("Georgi", "Iliev", 450, 10, 5));
            workers.Add(new Worker("Poly", "Pantev", 800, 8, 5));
            workers.Add(new Worker("Andrei", "Lukanov", 400, 8, 5));
            workers.Add(new Worker("Milen", "Cvetkov", 350, 8, 5));
            workers.Add(new Worker("Ivan", "Zvezdev", 250, 12, 4));
            workers.Add(new Worker("Slavi", "Trifonov", 600, 8, 5));
            workers.Add(new Worker("Georgi", "Milchev", 325, 10, 5));
            workers.Add(new Worker("Boris", "Soltariski", 900, 8, 5));

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            var orderedWorkers = workers.OrderByDescending(w => w.WeekSalary).ToList();

            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine(new string('=', 40));
            //Merge the lists and sort them by first name and last name.

            var mergeList = new List<Human>();

            mergeList.AddRange(students);
            mergeList.AddRange(workers);

            var sortedPeople = mergeList.OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName).ToList();

            foreach (var human in sortedPeople)
            {
                Console.WriteLine(string.Format(human.FirstName + " " + human.LastName));
            }
        }
    }
}
