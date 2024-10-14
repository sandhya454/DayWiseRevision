using System;

namespace Day32Concepts.NeedForProperties
{
    public class Person
    {
        private int _id;
        private string _name;
        private int _passMarks = 35;

        public void SetId(int Id)
        {
            if (Id < 0)
            {
                throw new Exception("Student id cannot be negative ");
            }

            this._id = Id;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name should not be empty");
            }
            this._name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._name) ? "NO Name" : this._name;
        }
        
        public int GetPassMarks()
        {
            return this._passMarks;
        }
    }
}
