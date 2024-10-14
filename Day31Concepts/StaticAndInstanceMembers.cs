using System;

namespace Day31Concepts.StaticAndInstanceMembers
{
    public class Circle
    {
       static float _PI ;
        int _Radius;

        static Circle()
        {
            Console.WriteLine("Static member called");
            _PI = 3.14f;
        }
        public Circle(int radius)
        {
            Console.WriteLine("Instance member called");
            this._Radius = radius;
        }

        public float CalculateArea()
        {
            return Circle._PI* this._Radius*this._Radius;
        }
    }

    public class Car
    {
        static int _totalCars;
        string _model;
        string _color;

        static Car()
        {
            Console.WriteLine("Static constructor called");
            _totalCars = 0;
        }

        public Car(string model, string color)
        {
            Console.WriteLine("Instance constructor called");
            this._model = model;
            this._color = color;
            _totalCars++;
        }

        public static int GetTotalCars()
        {
            return _totalCars;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine($"Model: {this._model}, Color: {this._color}");
        }
    }
}
