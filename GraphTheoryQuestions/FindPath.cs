using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace InterwiewQuestions.GraphTheoryQuestions
{
    
    public class FindPath
    {
        /// <summary>
        /// There is a bi-directional graph with n vertices, where each vertex is labeled from 0 to n - 1 (inclusive). 
        /// The edges in the graph are represented as a 2D integer array edges, 
        /// where each edges[i] = [ui, vi] denotes a bi-directional edge between vertex ui and vertex vi. 
        /// Every vertex pair is connected by at most one edge, and no vertex has an edge to itself.
        /// You want to determine if there is a valid path that exists from vertex source to vertex destination.
        /// Given edges and the integers n, source, and destination, return true if there is a valid path from source to destination,or false otherwise.
        /// </summary>
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {

            var parents = Enumerable.Range(0, n).ToArray();
            int find(int u) => parents[u] == u ? u : parents[u] = find(parents[u]);         

            Array.ForEach(edges, e => parents[find(e[0])] = find(e[1]));           

            return find(source) == find(destination);
            
        }


        /// <summary>
        /// In a town, there are n people labeled from 1 to n. 
        /// There is a rumor that one of these people is secretly the town judge.
        /// If the town judge exists, then
        /// The town judge trusts nobody.
        /// Everybody(except for the town judge) trusts the town judge.
        /// There is exactly one person that satisfies properties 1 and 2.
        /// You are given an array trust where trust[i] = [ai, bi] representing that the person labeled ai trusts the person labeled bi.
        /// Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.
        /// </summary>
        /// 
        public int FindJudge(int n, int[][] trust)
        {
            if (trust.Length == 1)
            {
                return trust[0][1];
            }

            for (var i = 0; i < trust.Length; i++)
            {
                if (trust[0][1] != trust[i][1])
                {
                    return -1;
                }
            }
            return trust[0][1];
        }

    }
}

