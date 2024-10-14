using System;

namespace Day34Concepts.EnumsConcepts
{
    public class Enums
    {
        public void PrintTypeAndValues()
        {
            short[] Values = (short[])Enum.GetValues(typeof(Gender));
            foreach (short value in Values)
            {
                Console.WriteLine(value);
            }

            string[] Names = (string[])Enum.GetNames(typeof(Gender));
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// enums are strongly typed so they cant implicitily interchangeable
        /// we have to use typecast. Enum is a class conatin static methods
        /// where enum is a keyword used to define enums.
        /// </summary>
        public void ExplicitExample()
        {
            Gender gender = (Gender)3;
            int Num = (int)Gender.Female;

            Gender gender1 = (Gender)Season.Winter;
        }
    }

    //default type is int we can change 
    public enum Gender : short
    {
        Unknown,
        Male,
        Female
    }

    public enum Season
    {
        Winter,
        Summer,
        Spring
    }
}
