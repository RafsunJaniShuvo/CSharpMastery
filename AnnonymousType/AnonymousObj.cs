using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousType
{
    public class AnonymousObj
    {
        public void SingleObject()
        {
            var Student = new { Id = 1, Name = "Rafsun", Dept = "Software" };
            Console.WriteLine(Student.GetType());
        }
        public void NestedObject()
        {
            var Student = new
            {
                ID = 1,
                FirstName = "Rafsun",
                LastName = "Shuvo",
                Address = new[]
                {
                    new  { ID = 1, City = "Magura", Village = "Takhalpur", Thana = "Sreepur" }
                }
                
               
            };
            Console.WriteLine(Student);
        }

        public void ArrayOfAnonymousType()
        {
            var Student = new[]
            {
                new {ID = 1,FirstName = "Rafsun",LastName = "Shuvo",Address = new[] { new {ID = 1 , City = "Magura" } } },
                new{ ID = 1,FirstName = "Rafsun",LastName = "Shuvo",Address = new[] { new { ID = 1, City = "Magura" } } } ,
                new {ID = 2,FirstName = "Ishtiak" , LastName = "" , Address = new[] { new { ID = 2 , City = "Nilphamari" } } },
                new {ID = 3,FirstName = "Sazzad" , LastName = "" , Address = new[] { new { ID = 3 , City = "Rajshahi" } } },
                new {ID = 4,FirstName = "Shakowat" , LastName = "" , Address = new[] { new {  ID = 4 , City = "Dinajpur" } } }
            };

            foreach(var item in Student)
            {
                Console.WriteLine($" Name : {item.FirstName} ");
                foreach(var item2 in item.Address)
                {
                    Console.WriteLine($"Address : {item2.City} ");
                }
            }
        }
    }
}
