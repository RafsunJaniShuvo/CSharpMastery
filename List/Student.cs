using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Student
    {
        public List<OwnershipInfo> OwnershipInfoArr { get; set; }
    }

    public class OwnershipInfo()
    {
        public string? OwnerFistName { get; set; }
        public string? OwnerLastName { get; set; }
        public DateTime? OwnerDateOfBirth { get; set; }
        public string? OwnerGovID { get; set; }
        public string? OwnerPhone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? state { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
    }







}
