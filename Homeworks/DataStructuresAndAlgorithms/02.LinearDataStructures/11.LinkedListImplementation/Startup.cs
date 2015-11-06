/*
 11.Implement the data structure linked list.

    Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
 */

namespace LinkedListImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var linkedList = new SampleLinkedList<int>();
            var firstItem = new ListItem<int>(1);

            linkedList.FirstItem = firstItem;
            firstItem.NextItem = new ListItem<int>(2);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
