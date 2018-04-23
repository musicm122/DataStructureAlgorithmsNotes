using System.Collections.Generic;

namespace Models
{

    public class Graph
    {
        public bool IsDirected;
        public bool IsWeighted;
        public int Weight { get; set; }

    }

    public class Edge
    {

    }

    public class Vertex
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; }
    }
}