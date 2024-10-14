using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI:AssemblyOneClassI
    {
        public void PrintId()
        {
            AssemblyOneClassI assemblyOne = new AssemblyOneClassI();
            //assemblyOne.ID;

            AssemblyTwoClassI assemblyTwo = new AssemblyTwoClassI();
            assemblyTwo.name = "savar technologies";
            base.name = ".NET Course";
            Console.WriteLine(assemblyTwo.name);
        }
    }
}
