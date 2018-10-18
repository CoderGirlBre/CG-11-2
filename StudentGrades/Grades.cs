using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGrades
{

    class Grade
    {
        public List<int> Grades { get; set; }
        public int AverageGrade { get; set; }

        public List<int> FindGrades(string studentdata)
        {
            //Seperating the names from the numbers 
            studentdata = studentdata.Substring(studentdata.IndexOf(' ') + 1);
            List<int> grades = new List<int>(Array.ConvertAll(studentdata.Split(' '), int.Parse));
            Grades = grades;
            
            return Grades;
        }

        public int FindAverageGrade()
        {
            AverageGrade = Convert.ToInt32(Grades.Average());
            return AverageGrade;
        }
    }
}
