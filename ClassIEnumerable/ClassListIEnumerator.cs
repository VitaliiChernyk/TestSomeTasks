using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIEnumerable
{
    class ClassListIEnumerator:IEnumerator
    {
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current
        {
            get { throw new NotImplementedException(); }
        }
    }
}
