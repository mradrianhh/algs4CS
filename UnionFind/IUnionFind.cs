using System;
using System.Collections.Generic;
using System.Text;

namespace algs4CS.UnionFind
{
    interface IUnionFind
    {
        public Boolean Connected(int p, int q);
        public void Union(int p, int q);
    }
}
