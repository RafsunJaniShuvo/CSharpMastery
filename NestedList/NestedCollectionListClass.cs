using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedList
{
    public class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } //= new List<Course>();
    }

    public class Course
    {
        public string? CourseName { get; set; }
        public int Credits { get; set; }

        public List<Assignment> Assignments { get; set; }// = new List<Assignment>();
    }
    public class Assignment
    {
        public string? Title { get; set; }
        public DateTime DueDate { get; set; }
    }


}
