using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class Collection
    {
        public IList<int> ListM()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };
            numbers.Add(4);
            numbers.Add(5);
            numbers.AddRange( new List<int> {  7, 8, 9, 10 } );
            return numbers;
        }
    }
}
