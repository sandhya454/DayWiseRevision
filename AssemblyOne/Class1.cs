using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID = 101;
        protected internal string name;
    }

    public class AssemblyOneClassII
    {
        public void PrintId()
        {
            AssemblyOneClassI assemblyOne = new AssemblyOneClassI();
            Console.WriteLine(assemblyOne.ID);
        }
    }
}
