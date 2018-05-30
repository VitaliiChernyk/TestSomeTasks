using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassIEnumerable
{
    internal class ClassListIEnumerable : IEnumerable
    {
        #region private memebers

        private readonly string _id;
        private ArrayList _students;

        #endregion

        #region Properties

        public string ID
        {
            get { return _id; }
        }

        #endregion

        #region Constructor

        public ClassListIEnumerable(string id)
        {
            _id = id;
            _students = new ArrayList();
            _students.Add(new Student("12345", "Jonh", "Smith"));
            _students.Add(new Student("65432", "Jane", "Doe"));
            _students.Add(new Student("09876", "Bob", "Jonson"));
        }

        #endregion

        #region IEnumerable memebers

        public IEnumerator GetEnumerator()
        {
            return (_students as IEnumerable).GetEnumerator();
        }

        #endregion
        #region ClassListIEnumerator
        class ClassListIEnumerator : IEnumerator
        {
            private ClassListIEnumerable _classListIEnumerable;
            private int _index;

            public ClassListIEnumerator(ClassListIEnumerable classListIEnumerable)
            {
                _classListIEnumerable = classListIEnumerable;
                _index = -1;
            }
            #region Ienumerator Memebers

            public bool MoveNext()
            {
                _index++;
                if (_index >= _classListIEnumerable._students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                _index = -1;
            }

            public object Current
            {
                get { return _classListIEnumerable._students[_index]; }
            }
            #endregion
        }
        #endregion
    }
}
