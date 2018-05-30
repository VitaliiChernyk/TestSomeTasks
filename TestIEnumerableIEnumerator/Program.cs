using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIEnumerableIEnumerable;

namespace TestIEnumerableIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            foreach (Books book in library)
            {
                Console.WriteLine(book.Name);
            }
            Console.ReadKey();
        }
    }
}
