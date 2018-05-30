using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassListIEnumerable myClass = new ClassListIEnumerable("History 204");
            foreach (Student student in myClass)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }

    }
}
