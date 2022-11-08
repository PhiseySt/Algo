using BFAlgorithm;

public class BellmanFordAlgo
{

    public Graph CreateGraph(int verticesCount, int edgesCount)
    {
        Graph graph = new()
        {
            VerticesCount = verticesCount,
            EdgesCount = edgesCount
        };
        graph.Edges = new Edge[edgesCount];

        return graph;
    }

    public void BellmanFord(Graph graph, int source)
    {
        int verticesCount = graph.VerticesCount;
        int edgesCount = graph.EdgesCount;
        int[] distance = new int[verticesCount];

        for (int i = 0; i < verticesCount; i++)
            distance[i] = int.MaxValue;

        distance[source] = 0;

        for (int i = 1; i <= verticesCount - 1; ++i)
        {
            for (int j = 0; j < edgesCount; ++j)
            {
                int u = graph.Edges[j].Source;
                int v = graph.Edges[j].Destination;
                int weight = graph.Edges[j].Weight;

                if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                    distance[v] = distance[u] + weight;
            }
        }

        for (int i = 0; i < edgesCount; ++i)
        {
            int u = graph.Edges[i].Source;
            int v = graph.Edges[i].Destination;
            int weight = graph.Edges[i].Weight;

            if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                Console.WriteLine("Graph contains negative weight cycle.");
        }

        Print(distance, verticesCount);
    }

    private void Print(int[] distance, int count)
    {
        Console.WriteLine("Vertex distance from source");

        for (int i = 0; i < count; ++i)
            Console.WriteLine("{0}\t {1}", i, distance[i]);
    }


}
