using Microsoft.VisualBasic;
using NestedList;
using System.Xml.Linq;

Student student = new Student()
{
    Name = "Rafsun",

    Age = 27,
    Courses = new List<Course>()
    {
        new Course()
        {
            CourseName = "Data Structure",
            Credits = 4,
            Assignments = new List<Assignment>()
            {
                new Assignment()
                {
                    Title = "Algebra",
                    DueDate = DateTime.UtcNow
                }
            }
        }
    }
};


Student student2 = new Student();
student2.Name = "Rafsun Jani Shuvo";
student2.Age = 27;
student2.Courses = new List<Course>();
Course course = new Course();
course.CourseName = "Algorithm";
course.Credits = 4;
student2.Courses.Add(course);
course.Assignments = new List<Assignment>();
Assignment assignment = new Assignment();
assignment.Title = "Eco";
assignment.DueDate = DateTime.UtcNow;
course.Assignments.Add(assignment);

Console.WriteLine("ok");


