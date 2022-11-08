namespace Dijkstra;

public class Dijkstra
{
    public void DijkstraAlgo(int[,] graph, int source, int verticesCount)
    {
        var distance = new int[verticesCount];
        var shortestPathTreeSet = new bool[verticesCount];

        for (var i = 0; i < verticesCount; ++i)
        {
            distance[i] = int.MaxValue;
            shortestPathTreeSet[i] = false;
        }

        distance[source] = 0;

        for (var count = 0; count < verticesCount - 1; ++count)
        {
            var u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
            shortestPathTreeSet[u] = true;

            for (var v = 0; v < verticesCount; ++v)
                if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    distance[v] = distance[u] + graph[u, v];
        }

        Print(distance, verticesCount);
    }

    private int MinimumDistance(IReadOnlyList<int> distance, IReadOnlyList<bool> shortestPathTreeSet, int verticesCount)
    {
        var min = int.MaxValue;
        var minIndex = 0;

        for (var v = 0; v < verticesCount; ++v)
        {
            if (shortestPathTreeSet[v] == false && distance[v] <= min)
            {
                min = distance[v];
                minIndex = v;
            }
        }

        return minIndex;
    }
    private void Print(IReadOnlyList<int> distance, int verticesCount)
    {
        Console.WriteLine("Vertex Distance from source");

        for (var i = 0; i < verticesCount; ++i)
            Console.WriteLine($"{i}\t  {distance[i]}");
    }
}