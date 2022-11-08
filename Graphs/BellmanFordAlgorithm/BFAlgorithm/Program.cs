using BFAlgorithm;

var verticesCount = 5;
var EdgesCount = 8;
BellmanFordAlgo algo = new();
var ourGraph = algo.CreateGraph(verticesCount, EdgesCount);

AddDataGraph(ourGraph);
algo.BellmanFord(ourGraph, 0);

void AddDataGraph(Graph graph1)
{
    // Edges 0-1
    graph1.Edges[0].Source = 0;
    graph1.Edges[0].Destination = 1;
    graph1.Edges[0].Weight = -1;

    // Edges 0-2
    graph1.Edges[1].Source = 0;
    graph1.Edges[1].Destination = 2;
    graph1.Edges[1].Weight = 4;

    // Edges 1-2
    graph1.Edges[2].Source = 1;
    graph1.Edges[2].Destination = 2;
    graph1.Edges[2].Weight = 3;

    // Edges 1-3
    graph1.Edges[3].Source = 1;
    graph1.Edges[3].Destination = 3;
    graph1.Edges[3].Weight = 2;

    // Edges 1-4
    graph1.Edges[4].Source = 1;
    graph1.Edges[4].Destination = 4;
    graph1.Edges[4].Weight = 2;

    // Edges 3-2
    graph1.Edges[5].Source = 3;
    graph1.Edges[5].Destination = 2;
    graph1.Edges[5].Weight = 5;

    // Edges 3-1
    graph1.Edges[6].Source = 3;
    graph1.Edges[6].Destination = 1;
    graph1.Edges[6].Weight = 1;

    // Edges 4-3
    graph1.Edges[7].Source = 4;
    graph1.Edges[7].Destination = 3;
    graph1.Edges[7].Weight = -3;
}