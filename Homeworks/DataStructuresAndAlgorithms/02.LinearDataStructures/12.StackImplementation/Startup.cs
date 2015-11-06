/*
 12.Implement the ADT stack as auto-resizable array.

    Resize the capacity on demand (when no space is available to add / insert a new element).   
 */

namespace StackImplementation
{
    using System;

    public class Startup
    {
        static void Main(string[] args)
        {
            var stack = new SampleStack<int>();

            for (int i = 1; i <= 10; i++)
            {
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}