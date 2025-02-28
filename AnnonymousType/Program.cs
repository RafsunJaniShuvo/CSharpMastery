//dynamic data = new { Name = "Rafsun", Amount = 500 }; // annonymous object

//Console.WriteLine(data.Name); // but dynamic type is only executes runtime 


//object obj = "Hello world"; //
//if(obj is string s) // is keyword is used for type checking and pattern matching
//{
//    Console.WriteLine($"{s} is a string");
//}


using AnnonymousType;

AnonymousObj anonymousObj = new AnonymousObj();
anonymousObj.SingleObject(); 
anonymousObj.NestedObject();
anonymousObj.ArrayOfAnonymousType();