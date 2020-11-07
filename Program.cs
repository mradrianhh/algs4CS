using algs4CS.UnionFind;
using System;

namespace algs4CS
{
    class Program
    {
        static void Main(string[] args)
        {
            WQUFPC qf = new WQUFPC(10);
            Console.WriteLine(qf.Connected(0, 9));
            qf.Union(0, 9);
            Console.WriteLine(qf.Connected(0, 9));
        }
    }
}
