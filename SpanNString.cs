using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace span_benchmark_app
{
    [RankColumn]
    [Orderer (SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class SpanNString {
        private const string FullName = "James Sam Smith";
        private static readonly NameParser Parser = new NameParser();

        [Benchmark (Baseline = true)]
        public void GetLastName () {
            Parser.GetLastName (FullName);
        }

        [Benchmark]
        public void GetLastNameUsingSubstring () {
            Parser.GetLastNameUsingSubstring (FullName);
        }

        [Benchmark]
        public void GetLastNameWithSpan () {
            Parser.GetLastNameWithSpan (FullName);
        }
    }
}