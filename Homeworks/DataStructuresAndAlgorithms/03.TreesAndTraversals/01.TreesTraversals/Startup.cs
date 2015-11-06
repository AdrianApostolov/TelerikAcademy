namespace TreesTraversals
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;


    public class Startup
    {
        static void Main()
        {
            var input = ReadInput();

            Console.WriteLine("Root: " + FindTreeRoot(input));
            Console.WriteLine("Leaves: " + string.Join(", ", FindTreeLeafs(input)));
            Console.WriteLine("Middle: " + string.Join(", ", FindMiddleNodes(input)));
            Console.WriteLine("One of the longest path: " + string.Join(", ", FindLongestPath(FindTreeRoot(input))));
        }

        public static Node<int>[] ReadInput()
        {
            var input = new StringReader(@"7
                                        2 4
                                        3 2
                                        5 0
                                        3 5
                                        5 6
                                        5 1");

            Console.SetIn(input);

            var n = int.Parse(Console.ReadLine());

            var treeNodes = new Node<int>[n];
            for (int i = 0; i < n; i++)
            {
                treeNodes[i] = new Node<int>(i);
            }

            for (int i = 0; i < n - 1; i++)
            {
                var parentChildPair = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var parentValue = int.Parse(parentChildPair[0]);
                var childValue = int.Parse(parentChildPair[1]);

                treeNodes[parentValue].Children.Add(treeNodes[childValue]);
                treeNodes[childValue].HasParent = true;
            }

            return treeNodes;
        }

        private static Node<int> FindTreeRoot(IEnumerable<Node<int>> nodes)
        {
            return nodes.FirstOrDefault(x => !x.HasParent);
        }

        private static IEnumerable<Node<int>> FindTreeLeafs(IEnumerable<Node<int>> nodes)
        {
            return nodes.Where(x => !x.HasChildren).ToList();
        }

        private static IEnumerable<Node<int>> FindMiddleNodes(IEnumerable<Node<int>> nodes)
        {
            return nodes.Where(x => x.HasChildren && x.HasParent).ToList();
        }

        private static List<Node<int>> FindLongestPath(Node<int> root)
        {
            List<Node<int>> path = root.Depth;
            return path;
        }
    }
}
