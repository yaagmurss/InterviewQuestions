using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions.GraphTheoryQuestions
{
    public class DepthFirstSearch
    {
            public int removeStones(int[][] stones)
            {
                int n = stones.Length;
                if (n <= 1)
                {
                    return 0;
                }

                var graph = new List<List<int>>{};
                for (int i = 0; i < n; i++)
                {
                graph[i] = new List<int> { };
                }            


                for (int i = 0; i < n; i++)
                {
                    int[] u = stones[i];
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        int[] v = stones[j];
                        if (u[0] == v[0] || u[1] == v[1])
                        {
                            graph[i].Add(j);
                        }
                    }
                }

            return n;


            //    boolean[] visited = new boolean[n];
            //    int ans = 0;

            //    for (int i = 0; i < n; i++)
            //    {
            //        if (visited[i])
            //        {
            //            continue;
            //        }

            //        dfs(graph, visited, i);
            //        ans++;
            //    }

            //    return n - ans;
            //}

            //private static void dfs(List<Integer>[] graph, boolean[] visited, int start)
            //{

            //    visited[start] = true;

            //    List<Integer> neighbors = graph[start];
            //    for (int x : neighbors)
            //    {
            //        if (visited[x])
            //        {
            //            continue;
            //        }

            //        dfs(graph, visited, x);
            //    }
            }
        }
    }

