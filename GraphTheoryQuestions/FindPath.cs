using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InterwiewQuestions.GraphTheoryQuestions
{
    /// <summary>
    /// There is a bi-directional graph with n vertices, where each vertex is labeled from 0 to n - 1 (inclusive). 
    /// The edges in the graph are represented as a 2D integer array edges, 
    /// where each edges[i] = [ui, vi] denotes a bi-directional edge between vertex ui and vertex vi. 
    /// Every vertex pair is connected by at most one edge, and no vertex has an edge to itself.
    /// You want to determine if there is a valid path that exists from vertex source to vertex destination.
    /// Given edges and the integers n, source, and destination, return true if there is a valid path from source to destination,or false otherwise.
    /// </summary>
    public class FindPath
    {
       
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {

            var parents = Enumerable.Range(0, n).ToArray();
            int find(int u) => parents[u] == u ? u : parents[u] = find(parents[u]);         

            Array.ForEach(edges, e => parents[find(e[0])] = find(e[1]));           

            return find(source) == find(destination);
            
        }
    }
}
