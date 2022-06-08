using BenchmarkDotNet.Running;
using System;

namespace BenchmarkForVsForeachDotnet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ForVsForEachBenchmark>();
        }
    }
}
