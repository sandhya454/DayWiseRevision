
namespace Day29Concepts.ApplicationDebugging
{
    public class Maths
    {
        /// <summary>
        /// Debug is used to view the execution of code in line by line,
        /// step over is used to move to next line, step in is used to step
        /// into the function,stepout is used to get outof the function
        /// and to watch the variables we have quick watch and add watch.
        /// the difference between the debug and release mode is debug is 
        /// used for development and release mode is used in production level
        /// to code optimization
        /// </summary>
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
