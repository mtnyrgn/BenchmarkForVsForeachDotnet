// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarlForVsForeachDotnet6;

var summary = BenchmarkRunner.Run<ForVsForEachBenchmark>();
