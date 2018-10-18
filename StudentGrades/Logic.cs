using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrades
{

    class Logic

    {
        public void Run()
        {
            Student student = new Student();
            Grade grade = new Grade();
            
            //Read a line of data in the .txt file and assign the value. 
            student.StudentData = student.ReadData();

            string temp = student.StudentData;
            while (student.StudentData != null)
            {
                student.StudentName = student.FindStudentName();
                Console.Write(student.StudentName + " ");
                
                //Removing names and seperating the numbers into a list.
               grade.Grades = grade.FindGrades(temp);

                grade.AverageGrade = grade.FindAverageGrade();
                Console.WriteLine(grade.AverageGrade);
                
                student.StudentData = student.ReadData();
                temp = student.StudentData;
            }
        }
    }
}
