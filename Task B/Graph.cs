using System;
using System.Collections.Generic;

namespace Task_B
{
    internal class Graph
    {
        private LinkedList<GraphNode> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        public void AddNode(string name)
        {
            nodes.AddLast(new GraphNode(name));
        }

        public GraphNode GetNodeByName(string name)
        {
            foreach (GraphNode n in nodes)
            {
                if (name == n.Name)
                    return n;
            }
            return null;
        }

        public void AddEdge(string from, string to)
        {
            GraphNode n1 = GetNodeByName(from);
            GraphNode n2 = GetNodeByName(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }
        }

        public int NumNodesGraph()
        {
            return nodes.Count;
        }

        public int NumEdgesGraph()
        {
            int allEdges = 0;

            foreach (GraphNode n in nodes)
            {
                allEdges += n.GetAdjList().Count;
            }

            return allEdges;
        }

        public List<string> GetAllNodes()
        {
            List<string> nodeNames = new List<string>();
            foreach (GraphNode node in nodes)
            {
                nodeNames.Add(node.Name);
            }
            return nodeNames;
        }
    }
}
