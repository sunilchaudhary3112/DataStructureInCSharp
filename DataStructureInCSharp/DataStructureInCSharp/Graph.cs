using System;
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
        public void addeEdge(int source, int dest)
        {
            int i = Vertices.IndexOf(source);
            int j = Vertices.IndexOf(dest);
            if(i != -1 || j != -1)
            {

            }
            
        }
            

    }
}
