using System;
using System.Collections.Generic;

namespace Algorithm_Homework_1
{
    internal class DFS
    {
        class DFSGraph
        {
            private Dictionary<char, List<char>> graph;

            public DFSGraph(Dictionary<char, List<char>> adjencyList)
            {
                graph = adjencyList;
            }

            public List<char> DFS(char startNode)
            {
                List<char> visitedNodes = new List<char>();
                HashSet<char> visited = new HashSet<char>();
                DFSUtil(startNode, visited, visitedNodes);
                return visitedNodes;
            }

            private void DFSUtil(char currentNode, HashSet<char> visited, List<char> visitedNodes)
            {
                visited.Add(currentNode);
                visitedNodes.Add(currentNode);

                foreach (char neighbor in graph[currentNode])
                {
                    if (!visited.Contains(neighbor))
                    {
                        DFSUtil(neighbor, visited, visitedNodes);
                    }
                }
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                Dictionary<char, List<char>> adjencyList = new Dictionary<char, List<char>>(){
                { 'A', new List<char>{ 'B', 'C' } },
                { 'B', new List<char>{ 'D', 'E' } },
                { 'C', new List<char>{ 'F' } },
                { 'D', new List<char>() },
                { 'E', new List<char>{ 'F' } },
                { 'F', new List<char>() }
                };

                DFSGraph dfsGraph = new DFSGraph(adjencyList);
                char startNode = 'A';
                List<char> visitedNodes = dfsGraph.DFS(startNode);

                Console.WriteLine("Traveled from node" + startNode + ": ");
                foreach (char node in visitedNodes)
                {
                    Console.Write(node + " ");
                }
            }
        }
    }
}
