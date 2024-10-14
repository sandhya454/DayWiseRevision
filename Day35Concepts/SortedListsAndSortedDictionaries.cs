using System;
using System.Collections.Generic;

namespace Day35Concepts.SortedListsAndSortedDictionaries
{
    public class SortedDictionaryExamples
    {
        public void SortedDictionaryExample()
        {
            var fileInfo = new SortedDictionary<string, string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");

            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"key :{kvp.Key} and value:{kvp.Value}");
            }

            Console.WriteLine("Press any key to add another file");
            Console.ReadLine();
            fileInfo.Add("bmp", "paint.exe");

            Console.WriteLine("\n Updated file info list:");
            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"key :{kvp.Key} and value:{kvp.Value}");
            }
        }

        public void DisplaySortedDictionary()
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            // Add some key-value pairs
            sortedDictionary.Add(3, "Three");
            sortedDictionary.Add(1, "One");
            sortedDictionary.Add(2, "Two");

            // The items will be sorted by key automatically
            Console.WriteLine("SortedDictionary elements (sorted by key):");
            foreach (KeyValuePair<int, string> kvp in sortedDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Accessing specific elements by key
            Console.WriteLine($"\nValue associated with key 2: {sortedDictionary[2]}");

            // Removing a key-value pair
            sortedDictionary.Remove(1);
            Console.WriteLine("\nSortedDictionary elements after removing key 1:");
            foreach (KeyValuePair<int, string> kvp in sortedDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }

    public class SortedListsExamples
    {
        public void SortedListsExample()
        {
            var fileInfo = new SortedList<string, string>();
            fileInfo.Add("txt", "notepad.exe");
            fileInfo.Add("doc", "wordpad.exe");

            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"key :{kvp.Key} and value:{kvp.Value}");
            }

            Console.WriteLine("Press any key to add another file");
            Console.ReadLine();
            fileInfo.Add("bmp", "paint.exe");

            Console.WriteLine("\n Updated file info list:");
            foreach (var kvp in fileInfo)
            {
                Console.WriteLine($"key :{kvp.Key} and value:{kvp.Value}");
            }
        }

        public void DisplaySortedLists()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();

            // Add some key-value pairs
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");

            // The items will be sorted by key automatically
            Console.WriteLine("SortedList elements (sorted by key):");
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Accessing specific elements by key
            Console.WriteLine($"\nValue associated with key 2: {sortedList[2]}");

            // Removing a key-value pair
            sortedList.Remove(1);
            Console.WriteLine("\nSortedList elements after removing key 1:");
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
