﻿using System;
using System.Linq;

namespace CSharpOOP_ExtMethodsDelegatesLambda
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }

    class FirstBeforeLast
    {
        static void Main()
        {
            Student[] ClassMates = new Student[]
            {
                new Student("Ivan", "Debelov", 23),
                new Student("Georgi", "Groznev", 34),
                new Student("Didi", "Smotleva", 23),
                new Student("Ivailo", "Tupev", 43),
                new Student("Delqn", "Anabolnii", 23),
            };

            Sort(ClassMates);

            // 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            var SortedClassMates =
            from student in ClassMates
            where student.Age > 18 && student.Age < 24
            select student;

            foreach (Student student in SortedClassMates)
            {
                Console.Write(student.FirstName + " ");
                Console.Write(student.LastName + " ");
                Console.Write(student.Age);
                Console.WriteLine();
            }

            // 5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the 
            // students by first name and last name in descending order. Rewrite the same with LINQ.
            var OrderByAndThenBy = ClassMates.OrderBy((student) => student.FirstName).ThenBy((student) => student.LastName);
            Console.WriteLine("\nWith OrderBy() and ThenBy()");
            foreach (Student student in OrderByAndThenBy)
            {
                Console.Write(student.FirstName + " ");
                Console.Write(student.LastName + " ");
                Console.Write(student.Age);
                Console.WriteLine();
            }

            // Lets do the same with LINQ
            var withLINQ =
            from student in ClassMates
            orderby student.FirstName, student.LastName
            select student;
            Console.WriteLine("\nWith LINQ");
            foreach (var student in withLINQ)
            {
                Console.Write(student.FirstName + " ");
                Console.Write(student.LastName + " ");
                Console.Write(student.Age);
                Console.WriteLine();
            }

        }
        static void Sort(Student[] ClassMates)
        {
            var SortedClassMates =
            from student in ClassMates
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

            foreach (Student student in SortedClassMates)
            {
                Console.Write(student.FirstName + " ");
                Console.Write(student.LastName);
                Console.WriteLine();
            }
        }
    }
}