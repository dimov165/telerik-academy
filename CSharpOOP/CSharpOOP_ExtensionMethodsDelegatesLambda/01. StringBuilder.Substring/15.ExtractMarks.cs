﻿using StudentGroups;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractMarks
{
    class ExtractMarks
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Penchev", 42412, "+028815124", "pencho@gmail.com", 3);
            student1.AddMark(6);
            student1.AddMark(2);
            student1.AddMark(4);

            Student student2 = new Student("Mitko", "Genchev", 42406, "028815124", "pencho@abv.bg", 2);
            student2.AddMark(6);
            student2.AddMark(6);

            Student student3 = new Student("Stamen", "Penchev", 42414, "05681244", "pencho@gmail.com", 1);
            Student student4 = new Student("Tsvetko", "Ivanov", 42406, "0568815124", "pencho@abv.bg", 4);
            student4.AddMark(6);
            student4.AddMark(6);
            student4.AddMark(3);
            student4.AddMark(4);

            Student student5 = new Student("Genadi", "Penchev", 42416, "056881511251", "pencho@gmail.com", 2);
            Student student6 = new Student("Evgeni", "Penov", 42417, "052881512131", "pencho@gmail.com", 2);
            Student student7 = new Student("Misho", "Genov", 42418, "+028815124", "pencho@gmail.com", 3);
            Student student8 = new Student("Vonko", "Penchev", 42406, "028815124", "pencho@abv.bg", 2);
            student8.AddMark(6);
            student8.AddMark(6);

            Student student9 = new Student("Conko", "Todorov", 424110, "+028815124", "pencho@gmail.com", 2);
            Student student10 = new Student("Ronko", "Penchev", 424111, "028815124", "pencho@abv.bg", 3);

            List<Student> students = new List<Student>()
            {
                student1, student2, student3, student4, student5, student6, student7, student8, student9, student10
            };

            var extractedMarks = students.Where(s => s.FN.ToString()
                .EndsWith("06")).Select(s => string.Join(", ", s.Marks));

            foreach (var marks in extractedMarks)
                Console.WriteLine(marks);
        }
    }
}