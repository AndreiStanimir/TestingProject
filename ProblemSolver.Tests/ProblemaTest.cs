using System.IO;

// <copyright file="ProblemaTest.cs" company="Avira Operations GmbH &amp; Co. KG;">Copyright © Avira Operations GmbH &amp; Co. KG; 2021</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using Solver;

namespace Solver.Tests
{
    /// <summary>This class contains parameterized unit tests for Problema</summary>
    [PexClass(typeof(Problema))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class ProblemaTest
    {
        /// <summary>Test stub for .ctor(Int32, Int32, Int32, List`1&lt;Interval&gt;, List`1&lt;Interval&gt;)</summary>
        [PexMethod]
        public Problema ConstructorTest(
            int k,
            int n,
            int m,
            List<Interval> intervaleStudent,
            List<Interval> intervaleProfesor
        )
        {
            Problema target = new Problema(k, n, m, intervaleStudent, intervaleProfesor);
            return target;
            // TODO: add assertions to method ProblemaTest.ConstructorTest(Int32, Int32, Int32, List`1<Interval>, List`1<Interval>)
        }

        [PexMethod(MaxRunsWithoutNewTests = 200)]
        public void PrintIntervale([PexAssumeUnderTest] Problema target)
        {
            target.PrintIntervale();
            // TODO: add assertions to method ProblemaTest.PrintIntervale(Problema)
        }

        [PexMethod]
        [PexAllowedException(typeof(FileNotFoundException))]
        public Problema Constructor(string path)
        {
            Problema target = new Problema(path);
            return target;
            // TODO: add assertions to method ProblemaTest.Constructor(String)
        }
    }
}