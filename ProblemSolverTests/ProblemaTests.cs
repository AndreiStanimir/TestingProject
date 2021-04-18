using NUnit.Framework;
using Solver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solver.exceptions;
namespace Solver.Tests
{
    [TestFixture()]
    public class ProblemaTests
    {
        private const string OUTPUT_PATH = @"C:\Users\andrei.stanimir\source\repos\TestingProject\ProblemSolver\output_files\";

       

        [TestCase(4, 2, 2, new[] { 1, 11 }, new[] { 10, 13 }, new[] { 2, 5 }, new[] { 4, 12 }, 5, 9)]
        [TestCase(5, 2, 2, new[] { 1, 11 }, new[] { 10, 13 }, new[] { 2, 5 }, new[] { 4, 12 }, 5, 10)]

        public void SolveTest(int k, int n, int m, int[] xs, int[] ys, int[] xt, int[] yt, int resultX, int resultY)
        {
            var listaIntervale = new List<Interval>();
            for (int i = 0; i < n; i++)
            {
                Interval interval = new Interval(xs[i], ys[i]);
                listaIntervale.Add(interval);
            }
            var listaIntervale2 = new List<Interval>();
            for (int i = 0; i < m; i++)
            {
                Interval interval = new Interval(xt[i], yt[i]);
                listaIntervale2.Add(interval);
            }
            var problema = new Problema(k, n, m, listaIntervale, listaIntervale2);
            Interval solutie = problema.Solve();
            Assert.AreEqual(new Interval(resultX, resultY), solutie);
        }
        [TestCase("test_baza.txt",Category =("Base test"))]
        [TestCase("result1.txt"), Category("Boundary Analysis")]
        [TestCase("result2.txt"), Category("Boundary Analysis")]
        [TestCase("result3.txt"), Category("Boundary Analysis")]
        public void SolveProblem(string inputFile)
        {
            string outputFile = OUTPUT_PATH + Path.GetFileNameWithoutExtension(inputFile) + ".out";
            var expectedOutput = File.ReadAllText(outputFile);
            if (!File.Exists(outputFile))
            {
                Assert.Fail("output file not found");
            }
            if (string.IsNullOrEmpty(outputFile))
            {
                Assert.Fail("expected output file is empty");
            }
            
                Problema problema = new Problema(inputFile);
                Interval interval = problema.Solve();
                if (interval == null)
                {
                    Assert.That("-1".Equals(expectedOutput));
                    return;
                }
                else
                {
                    try
                    {
                        var x = int.Parse(expectedOutput.Split(' ')[0]);
                        var y = int.Parse(expectedOutput.Split(' ')[1]);

                        Assert.AreEqual(interval, new Interval(x, y));
                    }
                    catch
                    {
                        Assert.Fail("couldn't parse ouput file content");
                    }
                }
            
            //catch (FileNotFoundException e)
            //{
            //    Assert.Fail("input file doesn't exist");
            //    throw e;
            //}
            //catch (Exception e)
            //{
            //    Assert.AreEqual("exception", expectedOutput, "Error %s", e.Message);
            //    throw e;
            //}
        }

        [TestCase("exception1.txt"), Category("Equivalence partitioning")]
        [TestCase("exception2.txt"), Category("Equivalence partitioning")]
        public void ThrowsOutOfBounds(string input)
        {
            Assert.Catch<InvalidInputDataException>(() => SolveProblem(input));
        }
        [TestCase("exception3.txt"), Category("Equivalence partitioning")]
        public void ThrowsIntervalInvalid(string input)
        {
            Assert.Throws<IntervalInvalidException>(() => SolveProblem(input));
        }
        [TestCase("no_solution.txt")]
        public void NoSolution(string input)
        {
            SolveProblem(input);
        }
    }
}