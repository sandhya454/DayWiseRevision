using System;

namespace Day33Concepts.MultipleInheritance
{
    public interface IAcademic
    {
        void ShowAcademicResult();
    }

    public class Academic : IAcademic
    {
        public void ShowAcademicResult()
        {
            Console.WriteLine("Academic Result: Passed with distinction.");
        }
    }

    public interface ISports
    {
        void ShowSportsPerformance();
    }

    public class Sports : ISports
    {
        public void ShowSportsPerformance()
        {
            Console.WriteLine("Sports Performance: Won the interschool championship.");
        }
    }

    public class Student : IAcademic, ISports
    {
        private Academic academic = new Academic();
        private Sports sports = new Sports();

        public void ShowAcademicResult()
        {
            academic.ShowAcademicResult();
        }

        public void ShowSportsPerformance()
        {
            sports.ShowSportsPerformance();
        }
    }

    public interface ICamera
    {
        void TakePhoto();
    }

    public class Camera : ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking a photo...");
        }
    }

    public interface IPhone
    {
        void MakeCall();
    }

    public class Phone : IPhone
    {
        public void MakeCall()
        {
            Console.WriteLine("Making a phone call...");
        }
    }

    public class SmartPhone : ICamera, IPhone
    {
        Camera camera = new Camera();
        Phone phone = new Phone();

        public void TakePhoto()
        {
            camera.TakePhoto();
        }

        public void MakeCall()
        {
            phone.MakeCall();
        }
    }
}
