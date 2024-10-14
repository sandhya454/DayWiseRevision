﻿using System;

namespace Day32Concepts.Structures
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Customer(int id,string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name:{this._name} and Id:{this._id}");
        }
    }
}
