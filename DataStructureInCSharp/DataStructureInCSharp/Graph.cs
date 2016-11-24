using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    public class AdjMatrixGraph
    {
        public bool[,] adjMatrix;
        public int vertexCount;
        public AdjMatrixGraph(int vertexCount)
        {
            this.vertexCount = vertexCount;
            adjMatrix = new bool[vertexCount,vertexCount];
        }
        public void addEdege(int i, int j)
        {
            if(i >=0 && i < vertexCount && j > 0 && j < vertexCount)
            {
                adjMatrix[i, j] = true;
                adjMatrix[j, i] = true;
            }
        }
        public void removeEdge(int i , int j)
        {
            if (i >= 0 && i < vertexCount && j > 0 && j < vertexCount)
            {
                adjMatrix[i, j] = false;
                adjMatrix[j, i] = false;
            }
        }
    }
    public class AdjListGraph
    {
        public List<int> Vertices;
        public LinkedListL[] Edges;
        public int vertexCount;
        public AdjListGraph(int vertexCount)
        {
            this.vertexCount = vertexCount;
            Vertices = new List<int>();
            Edges = new LinkedListL[vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                Vertices.Add(i);
                Edges[i] = new LinkedListL();

            }
        }
        public void addEdge(int source, int dest)
        {
            int i = Vertices.IndexOf(source);
            int j = Vertices.IndexOf(dest);
            if(i != -1 || j != -1)
            {
                ListNode nodeI = new ListNode(dest);
                ListNode nodeJ = new ListNode(source);
                Edges[i].insertAtBegin(nodeI);
                Edges[j].insertAtBegin(nodeJ);
            }
            
        }

        public void displayGraph()
        {
            for(int k = 0; k < vertexCount ; k++)
            {
                int ii = Vertices.IndexOf(k);
                LinkedListL node = Edges[ii];
                if(node.head != null)
                {
                    Console.Write("nodes connected to " + ii + "->");
                    node.display();
                }
            }
        }
            

    }
}
