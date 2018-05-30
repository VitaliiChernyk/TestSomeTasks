using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIEnumerableIEnumerator;

namespace TestIEnumerableIEnumerable
{
    class Library : IEnumerable
    {
        private Books[] books;

        public Library()
        {
            books = new Books[]
            {
                new Books("Fathers and kids"), 
                new Books("War and peace"), 
                new Books("Evgenii Onegin")
            };
        }
        public int Length { get { return books.Length; } }
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}
