using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    internal class GraphNode
    {
        private string name; // data stored in the node.
        private LinkedList<string> adjList; // list of the names of the nodes that are adjacent

        // constructor of a GraphNode (pass the name of the person to be constructed)
        public GraphNode(string name)
        {
            this.name = name;
            adjList = new LinkedList<string>();
        }

        // set and get the data stored in the node
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        // add edge from this node to the node "to";
        // it is a *directed* graph.
        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.Name);
        }

        // return the adjacent list of the node
        public LinkedList<string> GetAdjList()
        {
            return adjList;
        }

        public void RemoveEdge(GraphNode targetNode) 
        {
            adjList.Remove(targetNode.Name);
        }
    }
}
