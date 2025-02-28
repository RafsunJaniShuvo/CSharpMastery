
//var i = 0;
//Console.WriteLine("Type of i is {0}", i.GetType());

//string str = "Hello world";
//Console.WriteLine("Type of str is {0}", str[0]);

//var dbl = 50.0d;
//Console.WriteLine("Type of dbl is {0}", dbl.GetType());


//var isValid = true;
//Console.WriteLine("Type of isValid is {0}", isValid.GetType());

//var Name = new { name = "Rafsun" };
//Console.WriteLine("Type of Name is {0}", Name.GetType());

//var arr = new[] { 1, 2, 3, 4, 5 };
//Console.WriteLine("Type of arr is {0}", arr.GetType());

//var file = new FileInfo("MyFile");
//Console.WriteLine("Type of file is {0}", file.GetType());



//Console.ReadLine();


//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Diagnostics;


//public class Program
//{
//    public static void Main()
//    {

//        IList<Student> studentList = new List<Student>() {
//                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
//                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
//                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
//                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
//                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
//            };

//        IList<Standard> standardList = new List<Standard>() {
//                new Standard(){ StandardID = 1, StandardName="Standard 1"},
//                new Standard(){ StandardID = 2, StandardName="Standard 2"},
//                new Standard(){ StandardID = 3, StandardName="Standard 3"}
//            };



//        var InnerJoinResult = studentList.Join(standardList,
//                                    Student => Student.StandardID,
//                                    Standard => Standard.StandardID,
//                                    (Student, Standard) => new
//                                    {
//                                        StudentName = Student.StudentName,
//                                        StandardName = Standard.StandardName
//                                    } );
//        foreach(var item in InnerJoinResult)
//        {
//            Console.WriteLine($"{item.StudentName} {item.StandardName}");
//        }
//       // System.Diagnostics.Debugger.Break();


//    }
//}

//public class Student
//{

//    public int StudentID { get; set; }
//    public string StudentName { get; set; }
//    public int Age { get; set; }
//    public int StandardID { get; set; }
//}


//public class Standard
//{

//    public int StandardID { get; set; }
//    public string StandardName { get; set; }
//}


using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static List<int> getLowestDifferenceList(List<(int,int)> list)
    {
        
        var differences = list.Select(pair => new
        {
            Pair = pair,
            Difference = Math.Abs(pair.Item1 - pair.Item2)
        }).ToList();

        var minimumDiffernce = differences.Min(x=>x.Difference);

        var minimumDiffenceList = differences.Where(x => x.Difference == minimumDiffernce)
            .ToList();

        List<int> result = new List<int>();
        foreach (var i in minimumDiffenceList)
        {
            result.Add(i.Pair.Item1);
            result.Add(i.Pair.Item2);
           
        }
        return result;

    }
    public static List<(int,int)> getAdjacentPairs(List<int> arr)
    {
        List<(int, int)> pairs = new List<(int, int)>();


        for (int i = 0; i < arr.Count-1; i++)
        {
           pairs.Add((arr[i], arr[i + 1]));
        }
        return pairs;

    }
    public static List<int> closestNumbers(List<int> arr)
    {
        arr.Sort();
        List<(int, int)> list = getAdjacentPairs(arr);
      
         List<int> result  = getLowestDifferenceList(list);
        
        return result;
    }

    public static void Main(string[] args)
    {
       List<int> result = closestNumbers(new List<int> { 5,4,3,2 }); // Output: YES 9
       Console.WriteLine(string.Join(" ", result));
    }
}
