using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassIEnumerable
{
    class Student
    {
        #region private members

        private readonly string _id;
        private string _firstName;
        private string _lastName;
        #endregion
        #region public properties
        public string ID { get { return _id; } }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion
        #region constructor
        public Student(string id, string firstName, string lastName)
        {
            this._id = id;
            this._lastName = lastName;
            this._firstName = firstName;
        }
        #endregion
        #region Overriding

        public override string ToString()
        {
            return String.Format("{0} {1}, ID: {2}", _firstName, _lastName, _id);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (Object.ReferenceEquals(this, obj)) return true;
            if (this.GetType() != obj.GetType()) return false;
            Student objStudent = (Student)obj;
            if (_id.Equals(objStudent._id)) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
        #endregion
    }
}
