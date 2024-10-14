using System;

namespace Day29Concepts
{
    public class Variables
    {
        int userNumber = 1234;//global variable

        /// <summary>
        /// A variable is a named memory location which is used to store
        /// the data to reuse.and variable name should be starts with
        /// _ or alphabets.
        /// </summary>
        public void VariableDeclaration()
        {
            int number = 123;
            float value = 123.43f;
            string name = "sandhya";
        }

        /// <summary>
        /// Varibles are two types Local Variables and Global Variables , if 
        /// a variable declared in inside of method or block{} then we can say it is
        /// a local variable ,if we declared the varaible outside of the method then we can say it 
        /// is a global variable.
        /// </summary>
        public void VariablesTypes()
        {
            string userName = "Technologies"; //local variable

            Console.WriteLine($"this is Global Variable {userNumber}");
            Console.WriteLine($"this is Local variable {userName}");
        }

        /// <summary>
        /// scope can be defined within {} ,variables defined within {} cannot
        /// accessed outside of {} due to its scope.
        /// </summary>
        public void VariableScope()
        {
            int number = 1234;

            {
                string name = "savar";
            }

            //Console.WriteLine(name);
        }
    }
}
