using System;
using System.Collections;

namespace DailyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            list1.Add("apple");
            list1.Add("banana");
            list1.Add("cherry");
            list1.Add("date");
            list1.Add("elderberry");

            Console.WriteLine("Total number of elements in the list1 are: " + list1.Count);

            Console.WriteLine("List");
            PrintList(list1);

            
            Console.WriteLine("Removing banana from list");
            RemoveItem(list1, "banana");
            Console.WriteLine("Updated List\n");
            PrintList(list1);

            Console.WriteLine("Inserting grape in list");
            InsertItem(list1, 2, "grape");
            Console.WriteLine("Updated List\n");

            PrintList(list1);

            Console.WriteLine("Searching for cherry in list:");
            SearchItem(list1, "cherry");
        }

        static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
            Console.ReadKey();
        }
        
    }

}
