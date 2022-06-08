``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.17763.1935 (1809/October2018Update/Redstone5)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|                       Method |     N |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD | Allocated |
|----------------------------- |------ |-------------:|-----------:|-----------:|-------------:|------:|--------:|----------:|
| **CalculateTotalSumWithForEach** |    **10** |     **27.05 ns** |   **0.558 ns** |   **0.917 ns** |     **26.72 ns** |  **1.00** |    **0.00** |         **-** |
|     CalculateTotalSumWithFor |    10 |     11.10 ns |   0.095 ns |   0.075 ns |     11.12 ns |  0.41 |    0.01 |         - |
|                              |       |              |            |            |              |       |         |           |
| **CalculateTotalSumWithForEach** |   **100** |    **252.16 ns** |   **4.679 ns** |   **5.388 ns** |    **252.03 ns** |  **1.00** |    **0.00** |         **-** |
|     CalculateTotalSumWithFor |   100 |    129.41 ns |   0.794 ns |   0.743 ns |    128.98 ns |  0.51 |    0.01 |         - |
|                              |       |              |            |            |              |       |         |           |
| **CalculateTotalSumWithForEach** |  **1000** |  **2,578.21 ns** |  **52.736 ns** | **155.494 ns** |  **2,620.02 ns** |  **1.00** |    **0.00** |         **-** |
|     CalculateTotalSumWithFor |  1000 |  1,311.99 ns |   6.684 ns |   5.581 ns |  1,310.36 ns |  0.51 |    0.03 |         - |
|                              |       |              |            |            |              |       |         |           |
| **CalculateTotalSumWithForEach** | **10000** | **24,274.88 ns** | **475.168 ns** | **739.780 ns** | **24,189.11 ns** |  **1.00** |    **0.00** |         **-** |
|     CalculateTotalSumWithFor | 10000 | 13,202.64 ns |  69.419 ns |  64.934 ns | 13,204.79 ns |  0.55 |    0.02 |         - |
