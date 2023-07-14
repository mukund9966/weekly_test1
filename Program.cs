using System;
using System.Collections;

namespace DailyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruitsList = new ArrayList();
            fruitsList.Add("apple");
            fruitsList.Add("banana");
            fruitsList.Add("cherry");
            fruitsList.Add("date");
            fruitsList.Add("elderberry");

            Console.WriteLine("Total number of elements in the fruitsList are: " + fruitsList.Count);

            Console.WriteLine("Printing elements in the ArrayList:");
            PrintList(fruitsList);

            Console.WriteLine("Removing an item from the ArrayList:");
            RemoveItem(fruitsList, "banana");
            PrintList(fruitsList);

            Console.WriteLine("Inserting an item into the ArrayList:");
            InsertItem(fruitsList, 2, "grape");
            PrintList(fruitsList);

            Console.WriteLine("Searching for an item in the ArrayList:");
            SearchItem(fruitsList, "cherry");
        }

        static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void RemoveItem(ArrayList list, string item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                Console.WriteLine("Item " + item + " removed.");
            }
            else
            {
                Console.WriteLine("Item " + item + " not found.");
            }
            Console.WriteLine();
        }

        static void InsertItem(ArrayList list, int index, string item)
        {
            if (index >= 0 && index <= list.Count)
            {
                list.Insert(index, item);
                Console.WriteLine("Item " + item + " inserted at position " + index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            Console.WriteLine();
        }

        static void SearchItem(ArrayList list, string item)
        {
            int index = list.IndexOf(item);
            if (index != -1)
            {
                Console.WriteLine( item +" found at index " + index);
            }
            else
            {
                Console.WriteLine("Item not found");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }

}
