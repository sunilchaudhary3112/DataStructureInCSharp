using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    public class Vertex
    {
        public char label;
        public bool visited;
        public Vertex(char label)
        {
            this.label = label;
            visited = false;

        }
    }

    public class Graph
    {
        public int maxVertices = 20;
        public Vertex[] vertexList;
        public int[,] adjMatrix;
        public Stack stack;
        public Queue queue;
        public int vertexCount;
        public Graph()
        {
            vertexList = new Vertex[maxVertices];
            adjMatrix = new int[maxVertices, maxVertices];
            vertexCount = 0;
            stack = new Stack();
            queue = new Queue();
            for(int i = 0; i < maxVertices; i++)
            {
                for(int j = 0; j < maxVertices; j++)
                {
                    adjMatrix[i, j] = 0;
                }
            }
        }
        public void addVertex(char label)
        {
            vertexList[vertexCount++] = new Vertex(label);
        }
        public void addEdge(int i, int j)
        {
            adjMatrix[i, j] = 1;
            adjMatrix[j, i] = 1;
        }
        public void displayVertex(int v)
        {
            Console.WriteLine("vertex visited is : " + vertexList[v].label);
        }
        public int getUnvisitedVertex(int v)
        {
            for(int i = 0; i < vertexCount; i++)
            {
                if(adjMatrix[v,i] == 1 && vertexList[i].visited == false)
                {
                    return i;
                }
            }
            return -1;
        }
        public void DFS()
        {
            vertexList[0].visited = true;
            displayVertex(0);
            stack.Push(0);

            while(stack.Count > 0)
            {
                int v = getUnvisitedVertex((int)stack.Peek());
                if(v == -1)
                {
                    stack.Pop();
                }
                else
                {
                    vertexList[v].visited = true;
                    displayVertex(v);
                    stack.Push(v);
                }
            }
            
        }

        public void BFS()
        {
            vertexList[0].visited = true;
            displayVertex(0);
            queue.Enqueue(0);
            int v1;
            while(queue.Count > 0)
            {
                int v2 =  (int)queue.Dequeue();
                while((v1 = getUnvisitedVertex(v2))!= -1)
                {
                    vertexList[v1].visited = true;
                    displayVertex(v1);
                    queue.Enqueue(v1);
                }
            }
        }

    }

    //public class AdjMatrixGraph
    //{
    //    public bool[,] adjMatrix;
    //    public int vertexCount;
    //    public AdjMatrixGraph(int vertexCount)
    //    {
    //        this.vertexCount = vertexCount;
    //        adjMatrix = new bool[vertexCount,vertexCount];
    //    }
    //    public void addEdege(int i, int j)
    //    {
    //        if(i >=0 && i < vertexCount && j > 0 && j < vertexCount)
    //        {
    //            adjMatrix[i, j] = true;
    //            adjMatrix[j, i] = true;
    //        }
    //    }
    //    public void removeEdge(int i , int j)
    //    {
    //        if (i >= 0 && i < vertexCount && j > 0 && j < vertexCount)
    //        {
    //            adjMatrix[i, j] = false;
    //            adjMatrix[j, i] = false;
    //        }
    //    }
    //}
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
