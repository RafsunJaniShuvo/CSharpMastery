using GenericCollections;
using System.Collections;

Collection collection = new Collection();
IList<int> ListOfInt = collection.ListM();
foreach(var item in ListOfInt)
{
    Console.WriteLine(item);
}