using System.Collections.Generic;

namespace Day37Concepts.EmployeeData
{
    public class EmployeeTestData
    {
        public List<Employee> GetEmployee()
        {
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mark",Email="Mark@gmail.com",Programming=new List<string>(){"C#","PHP","JAVA"},Languages=
                new List<Techs>{
                    new Techs(){Technology="C#"},
                    new Techs(){Technology="PHP"},
                    new Techs(){Technology="LINQ"}
                } },
                new Employee(){Id=8,Name="Mary",Email="Mary@gmail.com",Programming=new List<string>(){"LINQ","C#","MVC"},Languages=
                new List<Techs>{
                    new Techs(){Technology=".NET"},
                    new Techs(){Technology="C#"},
                    new Techs(){Technology="JAVA"}
                } },
                new Employee(){Id=3,Name="Joseph",Email="Joseph@gmail.com",Programming=new List<string>(){"LINQ","VB","SQL"},Languages=
                new List<Techs>{
                    new Techs(){Technology="PYTHON"},
                    new Techs(){Technology="LINQ"},
                    new Techs(){Technology="REACT"}
                } },
                new Employee(){Id=4,Name="Shaun",Email="Shaun@gamil.com",Programming=new List<string>(){"LINQ","C#","MVC"},Languages=new List<Techs>()},
                new Employee(){Id=5,Name="Lea",Email="Lea@gamil.com",Programming=new List<string>(){"LINQ","VB","SQL"},Languages=new List<Techs>()},
                new Employee(){Id=10,Name="Shaun",Email="Shaun@gamil.com",Programming=new List<string>(){"LINQ","C#","MVC"},Languages=new List<Techs>()},
                new Employee(){Id=6,Name="Lea",Email="Lea@gamil.com",Programming=new List<string>(){"LINQ","VB","SQL"},Languages=new List<Techs>()}
            };

            return employees;
        }
    }
}
