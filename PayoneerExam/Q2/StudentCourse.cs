using System;
using System.Collections.Generic;
using System.Text;

namespace PayoneerExam.Q2
{
    public class StudentCourse
    {
        public int StudentId;
        public List<int> Courses;

        public StudentCourse (int StudentId)
        {
            this.StudentId = StudentId;
        }
        public void getAllCoursesForStudent(List<StudentCourseGrade> ListOfItems)
        {
            this.Courses = new List<int>();
            foreach (var student in ListOfItems)
            {
                if (student.StudentId == this.StudentId)
                {
                    Courses.Add(student.CourseId);
                }
                
            }
            
        }
    }

}
