using System;

namespace Day32Concepts.Properties
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark;
        public string Email { get; set; }
        public int Id
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Id should not be negative");
                }

                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "NO Name" : this._name;
            }
        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
    }
}
