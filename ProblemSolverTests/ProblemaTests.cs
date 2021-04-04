using NUnit.Framework;
using Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver.Tests
{
    [TestFixture()]
    public class ProblemaTests
    {
        [Test()]
        public void BetweenTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void AreValuesInsideBoundsTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void ProblemaTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void ProblemaTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void ProblemaTest2()
        {
            Assert.Fail();
        }

        [Test()]
        public void PrintIntervaleTest()
        {
            Assert.Fail();
        }

        [TestCase(4, 2, 2,new []{1, 11 }, new[] { 10, 13 }, new[] { 2, 5 }, new[] { 4, 12 }, 5, 9)]
        [TestCase(5, 2, 2, new[] { 1, 11 }, new[] { 10, 13 }, new[] { 2, 5 }, new[] { 4, 12 }, 5, 10)]

        public void SolveTest(int k, int n,int m, int[] xs,int[] ys,int[] xt, int[] yt, int resultX,int resultY)
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
            Interval solutie= problema.Solve();
            Assert.AreEqual(new Interval(resultX, resultY), solutie);
        }
    }
}