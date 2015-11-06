namespace ShortestPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var start = 5;
            var end = 16;

            var q = new Queue<int>();

            while (start <= end)
            {
                q.Enqueue(end);

                if (end / 2 >= start)
                {
                    if (end % 2 == 0)
                    {
                        end /= 2;
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    if (end - 2 >= start)
                    {
                        end -= 2;
                    }
                    else
                    {
                        end--;
                    }
                }
            }

            Console.WriteLine(string.Join(" -> ", q.Reverse()));
        }
    }
}