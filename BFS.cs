using System;
using System.Collections.Generic;

namespace Algorithm_Homework_1
{
    internal class BFS
    {
        public static List<int> PerformBFS(Dictionary<int, List<int>> graph, int startVertex)
        {
            List<int> traversalORder = new List<int>();
            HashSet<int> visited = new HashSet<int>();


            if (!graph.ContainsKey(startVertex))
            {
                return traversalORder;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startVertex);
            visited.Add(startVertex);

            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                traversalORder.Add(vertex);

                foreach (int neighbor in graph[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }
            return traversalORder;
        }

        public static void Main(string[] args)
        {
            Dictionary<int, List<int>> adjacenyList = new Dictionary<int, List<int>>
            {
                {0, new List<int>() {1,2}},
                {1, new List<int>() {0, 3, 4}},
                {2, new List<int>() {0, 5}},
                {3, new List<int>() {1}},
                {4, new List<int>() {1}},
                {5, new List<int>() {2}},
            };

            int startVertex = 0;
            List<int> bfsTraversal = PerformBFS(adjacenyList, startVertex);

            Console.WriteLine("BFS Order starting from vertex: " + startVertex);
            foreach (int vertex in bfsTraversal)
            {
                Console.Write(vertex + " ");
            }
        }
    }
}
