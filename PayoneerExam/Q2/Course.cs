using System;
using System.Collections.Generic;
using System.Text;

namespace PayoneerExam.Q2
{
    public class Course
    {
        public int CourseId;
        public List<int> CourseGrades;

        public Course(int CourseId)
        {
            this.CourseId = CourseId;
        }


        public float getAverage(List<StudentCourseGrade> ListOfItems)
        {
            this.CourseGrades = new List<int>();
            float totalGrade = 0;
            foreach (var course in ListOfItems)
            {
                if (course.CourseId == this.CourseId)
                {
                    CourseGrades.Add(course.Grade);
                }
            }

            foreach (var grade in CourseGrades)
            {
                totalGrade += grade;
            }

            if (CourseGrades.Count == 0)
            {
                return 0;
            }

            return totalGrade / CourseGrades.Count;

        }

    }
}
