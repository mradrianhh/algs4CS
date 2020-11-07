using System;
using System.Collections.Generic;
using System.Text;

namespace algs4CS.UnionFind
{
    public class WQUFPC : IUnionFind
    {

        private int[] id;
        private int[] sz;

        public WQUFPC(int N)
        {
            id = new int[N];
            sz = new int[N];

            for(int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }

        private int root(int i)
        {
            while(i != id[i])
            {
                id[i] = id[id[i]];
                i = id[i];
            }
            return id[i];
        }

        public bool Connected(int p, int q)
        {
            return root(p) == root(q);
        }

        public void Union(int p, int q)
        {
            int i = root(p);
            int j = root(q);
            if(i == j)
            {
                return;
            }
            if(sz[i] < sz[j])
            {
                id[i] = j;
                sz[j] += sz[i];
            }
            else
            {
                id[j] = i;
                sz[i] += sz[j];
            }
        }
    }
}
