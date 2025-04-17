using List;
using System.Diagnostics.Metrics;
using System.Net;

Student listExampleClass = new Student()
{
    OwnershipInfoArr = new List<OwnershipInfo>()
    {
        new OwnershipInfo()
        {
        OwnerFistName = "",
        OwnerLastName = "",
        OwnerDateOfBirth = DateTime.Now,
        OwnerGovID = "",
        OwnerPhone = "",
        Address = "",
        City = "",
        state = "",
        Zip = "",
        Country = ""
        },
        new OwnershipInfo()
        {
        OwnerFistName = "",
        OwnerLastName = "",
        OwnerDateOfBirth = DateTime.Now,
        OwnerGovID = "",
        OwnerPhone = "",
        Address = "",
        City = "",
        state = "",
        Zip = "",
        Country = ""
        }

    }
 };

Student listExampleClass2 = new Student();

listExampleClass2.OwnershipInfoArr = new List<OwnershipInfo>();

OwnershipInfo ownershipInfo = new OwnershipInfo();

ownershipInfo.OwnerFistName= "";
ownershipInfo.OwnerLastName = "";
ownershipInfo.OwnerDateOfBirth = DateTime.Now;
ownershipInfo.OwnerGovID = "";
ownershipInfo.OwnerPhone = "";
ownershipInfo.Address = "";
ownershipInfo.City = "";
ownershipInfo.state = "";
ownershipInfo.Zip = "";
ownershipInfo.Country = "";
listExampleClass2.OwnershipInfoArr.Add(ownershipInfo);



Console.WriteLine("Ok");


