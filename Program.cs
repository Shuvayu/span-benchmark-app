using BenchmarkDotNet.Running;

namespace span_benchmark_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SpanNString>();
        }
    }
}