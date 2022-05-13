using PayoneerExam.Q2;
using System;
using System.Collections.Generic;

namespace PayoneerExam
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] arrayOfRates = { 5, 4, 9, 2, 8, 7, 7, 9, 6, 8 };
                int result = Q1.getMaxRevenue(arrayOfRates);
                Console.WriteLine("The max revenue is: " + result);

                int[] arrayOfRates2 = { 5, 4, 9, 2, 8, 7, 7, 6, 8 };
                int result2 = Q1.getMaxRevenue(arrayOfRates2);
                Console.WriteLine("The max revenue is: " + result2);

            ////////////Q2
            /// Q2 -1
            var items = new List<StudentCourseGrade>()
            {
                new StudentCourseGrade(){StudentId = 1,CourseId=1123,Grade = 34},
                new StudentCourseGrade(){StudentId = 1,CourseId=1124,Grade = 88},
                new StudentCourseGrade(){StudentId = 2,CourseId=1123,Grade = 65},
            };

            StudentCourse studentCourses = new StudentCourse(1);
           
            studentCourses.getAllCoursesForStudent(items);
            foreach (var courseId in studentCourses.Courses)
            {
                Console.WriteLine("for student Id: " + studentCourses.StudentId + "the courses is: " + courseId);
            }

            /// Q2 -2
            Course course1 = new Course(1123);
            Course course2 = new Course(1124);
            List<float> CourseAvgGrades = new List<float>();
            
            course2.getAverage(items);
            CourseAvgGrades.Add(course1.getAverage(items));
            CourseAvgGrades.Add(course2.getAverage(items));
            foreach (float avg in CourseAvgGrades)
            {
                Console.WriteLine("the average is: " + avg);
            }

            //Q3
            //1
            SELECT Players.PlayerId, Players.PlayerName, Game.Score
            FROM Players
            LEFT JOIN Game ON Players.PlayerId = Game.PlayerId
            where(Players.PlayerId, Game.Score) in 
                (select Game.Score, max(Score)
                from Game
                group by PlayerId)
            group by PlayerId
            order by PlayerId asc

            //2
            SELECT Players.PlayerId, Players.PlayerName
            FROM Players           
            where Players.CreatedDate is null;


            //3
            SELECT Players.PlayerId, Players.PlayerName, Game.Score
            FROM Players
            LEFT JOIN Game ON Players.PlayerId = Game.PlayerId
            where(Players.PlayerId, Game.Score) in 
                (select Game.Score > 100
                from Game
                group by PlayerId)
            group by PlayerId
            order by PlayerId asc



        }
    }
}
