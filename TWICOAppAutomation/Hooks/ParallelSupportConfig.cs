using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]
//Same parallel
//[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(5)]
//[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.MethodLevel)]

