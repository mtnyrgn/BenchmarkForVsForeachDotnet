using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarlForVsForeachDotnet6
{
    [MemoryDiagnoser]
    public class ForVsForEachBenchmark
    {
        private static Random random = new Random();
        private List<int> numberList;
        int totalSum = 0;

        [Params(10, 100, 1000, 10000)]
        public int N;

        public static List<int> RandomIntList(int length)
        {
            int min = 1;
            int max = 10;

            return Enumerable.Repeat(0, length).Select(i => random.Next(min, max)).ToList();
        }

        [GlobalSetup]
        public void Setup()
        {
            numberList = RandomIntList(N);
        }

        [Benchmark(Baseline = true)]
        public void CalculateTotalSumWithForEach()
        {
            foreach (int i in numberList)
            {
                totalSum += i;
            }
        }

        [Benchmark]
        public void CalculateTotalSumWithFor()
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                totalSum += i;
            }
        }
    }
}