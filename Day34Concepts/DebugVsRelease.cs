using System;

namespace Day34Concepts.DebugVsRelease
{
    public class MainClass
    {
        public void Example()
        {
            Method3();
        }

        public void Method3()
        {
            Method2();
        }

        public void Method2()
        {
            Method1();
        }

        public void Method1()
        {
            throw new Exception("Something Happepnd");
        }

        public void DisplayApp()
        {
#if DEBUG
            Console.WriteLine(DateTime.Now);
#endif
            Console.WriteLine("this is your application");
        }
    }
    public class DebugReleaseExample
    {
        public void Run()
        {
            Console.WriteLine("Program started.");

            // Code that runs only in Debug mode
#if DEBUG
            Console.WriteLine("Debugging information: Program is running in Debug mode.");
            DebugMethod();
#endif

            // Code that runs in both Debug and Release modes
            Console.WriteLine("This message appears in both Debug and Release builds.");

            PerformCalculation();

            Console.WriteLine("Program ended.");
        }

        private void DebugMethod()
        {
            Console.WriteLine("This method is only called in Debug mode.");
        }

        private void PerformCalculation()
        {
            int result = 0;

            for (int i = 0; i < 10; i++)
            {
                result += i;
            }

            Console.WriteLine($"The result of the calculation is: {result}");

            // Validation logic to detect potential errors in Debug mode
#if DEBUG
            if (result == 0)
            {
                Console.WriteLine("Debug: The result should not be zero.");
            }
#endif
        }
    }
}



