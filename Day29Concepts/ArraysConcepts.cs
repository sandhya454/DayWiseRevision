using System;

namespace Day29Concepts.ArraysConcepts
{
    public class Declarations
    {
        /// <summary>
        /// Arrays is used to store multiple values into a single varaible
        /// </summary>
        public void IntegerArray()
        {
            //declaration
            int[] employeeIds = new int[5];

            //initialization
            employeeIds[0] = 19;
            employeeIds[1] = 12;
            employeeIds[2] = 34;
            employeeIds[3] = 64;
            employeeIds[4] = 53;

            //access values in an array
            Console.WriteLine(employeeIds[1]);

            //declaration and initalization by inline
            int[] employeeIds1 = new int[5] { 17, 23, 4, 12, 34 };
            int[] employeeIds2 = new int[] { 12, 2, 8, 13, 5, 1, 10, 20 };
            int[] employeeIds3 = { 10, 20, 2, 45, 1, 4, 19, 23, 43 };
        }

        public void StringArray()
        {
            //declaration 
            string[] employeeNames = new string[5];

            //initialization
            employeeNames[0] = "Ram";
            employeeNames[1] = "Shyam";
            employeeNames[2] = "Varun";
            employeeNames[3] = "Tej";
            employeeNames[4] = "Pavan";

            //access values
            Console.WriteLine(employeeNames[4]);

            //declaration and initalization by inline
            string[] employeeNames1 = new string[5] { "Ram", "Shyam", "Varun", "Tej", "Pavan" };
            string[] employeeNames2 = new string[] { "Ram", "Shyam", "Varun", "Tej", "Pavan", "Akil" };
            string[] employeeNames3 = { "Ram", "Shyam", "Varun", "Tej", "Pavan", "Akil" };
        }

        public void FlaotArray()
        {
            float[] studentsPercentage=new float[5];

            studentsPercentage[0] = 12.87f;
            studentsPercentage[1] = 10.47f;
            studentsPercentage[2] = 9.87f;
            studentsPercentage[3] = 45.87f;
            studentsPercentage[4] = 93.87f;

            float[] studentsPercentage1 = new float[5] { 56.87f, 67.34f, 87.32f, 98.21f, 33.23f };
            float[] studentsPercentage2 = new float[] { 12.45f, 76.23f, 98.24f, 90.43f, 23.45f };
            float[] studentsPercentage3 = { 56.87f, 67.34f, 87.32f, 98.21f, 33.23f };
        }

        public void DecimalArray()
        {
            decimal[] studentsPercentage= new decimal[5];

            studentsPercentage[0] = 12.87m;
            studentsPercentage[1] = 10.47m;
            studentsPercentage[2] = 9.87m;
            studentsPercentage[3] = 45.87m;
            studentsPercentage[4] = 93.87m;

            decimal[] studentsPercentage1 = new decimal[5] { 21.45m, 76.34m, 87.23m, 54.21m, 78.65m };
            decimal[] studentsPercentage2 = new decimal[] { 21.45m, 76.34m, 87.23m, 54.21m, 78.65m };
            decimal[] studentsPercentage3 = { 21.45m, 76.34m, 87.23m, 54.21m, 78.65m };
        }

        public void DoubleArray()
        {
            double[] studentsPercentage= new double[5];
            studentsPercentage[0] = 12.87;
            studentsPercentage[1] = 10.47;
            studentsPercentage[2] = 9.87;
            studentsPercentage[3] = 45.87;
            studentsPercentage[4] = 93.87;

            double[] studentsPercentage1 = new double[5] { 21.45, 76.34, 87.23, 54.21, 78.65 };
            double[] studentsPercentage2 = new double[] { 21.45, 76.34, 87.23, 54.21, 78.65 };
            double[] studentsPercentage3 = { 21.45, 76.34, 87.23, 54.21, 78.65 };
        }
    }
}
