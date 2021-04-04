using Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver.Tests
{
    public class GenerateTestSets : CONSTANTS
    {
        public static List<Interval> GenerateValidInterval(int n)
        {

            var numbers = new int[n * 2];
            var rand = new Random();
            numbers[0] = rand.Next(CONSTANTS.MIN_INTERVAL_VALUE, CONSTANTS.MAX_INTERVAL_VALUE);
            for (int i = 1; i < n * 2; i++)
            {
                numbers[i] = rand.Next(numbers[i - 1], CONSTANTS.MAX_INTERVAL_VALUE);
                if (CONSTANTS.MAX_INTERVAL_VALUE - numbers[i] < n - i)
                    return GenerateValidInterval(n);
            }

            List<Interval> intervals = new List<Interval>(n);
            for (int i = 0; i < n * 2; i += 2)
            {
                intervals.Add(new Interval(numbers[i], numbers[i + 1]));
            }
            return intervals.OrderBy(i => Guid.NewGuid()).ToList();
        }
        private class CategoryPartitioning
        {
            void Generate()
            {
                var ks = new int[] { MIN_K - 1, MIN_K, MAX_K, MAX_K + 1 };
                var ns = new int[] { MIN_N - 1, MIN_N, MAX_N, MAX_N + 1 };
                var ms = new int[] { MIN_N - 1, MIN_N, MAX_N, MAX_N + 1 };

                foreach (var k in ks)
                {
                    foreach (var n in ns)
                        foreach (var m in ms)
                        {
                            var intervalsStudent = GenerateValidInterval(n);
                            var intervalsProffesor = GenerateValidInterval(n);
                            var problema = new Problema(k, n, m, intervalsStudent, intervalsProffesor);
                            problema.Solve();
                            //Console.WriteLine()
                        }
                }
            }
        }
    }
}