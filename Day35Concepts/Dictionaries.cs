using System;
using System.Collections.Generic;

namespace Day35Concepts.Dictionaries
{
    public class DictionaryExamples
    {
        public void DictionaryDeclaration()
        {
            var months = new Dictionary<int, string>
            {
                { 1,"January"},
                {2,"Februray" },
                {3,"March" },
                {4,"April" },
                {5,"May" },
                {6,"June" },
                {7,"July" },
            };
            months[8] = "August";
            months[9] = "September";
            months.Add(10, "October");
            months.Add(11, "November");
            months.Add(12, "December");
        }

        public void DictronaryCaseSensitive()
        {
            var days = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            days.Add("sun", "Sunday");
            days.Add("mon", "Monday");
            days.Add("tue", "Tuesday");
            days.Add("thu", "Thursday");

            //retrive values from dictionary
            var day = days["sun"];
            Console.WriteLine(day);

            //return bool if key present or not 
            var isExists = days.TryGetValue("wed", out string wed);
            Console.WriteLine(isExists);
        }

        public void EnnumratingDictinoary()
        {
            var days = new Dictionary<string, string>();
            days.Add("sun", "Sunday");
            days.Add("mon", "Monday");
            days.Add("tues", "Tuesday");
            days.Add("wed", "Wednesday");
            days.Add("thr", "Thursday");
            days.Add("fri", "Friday");
            days.Add("sat", "Saturday");

            foreach (var kvp in days)
            {
                Console.WriteLine($"Key:{kvp.Key} and Value:{kvp.Value}");
            }

            //only keys

            foreach(var kvp in days.Keys)
            {
                Console.WriteLine(kvp);
            }

            //only values
            foreach (var kvp in days.Values)
            {
                Console.WriteLine(kvp);
            }
        }

        public void DictionaryMethods()
        {
            var days = new Dictionary<string, string>();
            days.Add("sun", "Sunday");
            days.Add("mon", "Monday");
            days.Add("tues", "Tuesday");
            days.Add("wed", "Wednesday");
            days.Add("thr", "Thursday");
            days.Add("fri", "Friday");
            days.Add("sat", "Saturday");

            if (days.ContainsKey("sun"))
            {
                days.Remove("sun");
            }
            days.Clear();
            foreach (var kvp in days)
            {
                Console.WriteLine($"Key:{kvp.Key} and Value:{kvp.Value}");
            }
        }
    }
}
