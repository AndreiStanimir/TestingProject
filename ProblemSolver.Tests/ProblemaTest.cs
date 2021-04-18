using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using Solver;
using Solver.exceptions;

namespace Solver.Tests
{
    /// <summary>This class contains parameterized unit tests for Problema</summary>
    [TestFixture]
    [PexClass(typeof(Problema))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProblemaTest
    {
        /// <summary>Test stub for .ctor(Int32, Int32, Int32, List`1&lt;Interval&gt;, List`1&lt;Interval&gt;)</summary>

        /// <summary>Test stub for .ctor(Int32, Int32, Int32, List`1&lt;Interval&gt;, List`1&lt;Interval&gt;)</summary>
        [PexMethod]
        [PexAllowedException(typeof(InvalidInputDataException))]
        public Problema ConstructorTest(
            int k,
            int n,
            int m,
            List<Interval> intervaleStudent,
            List<Interval> intervaleProfesor
        )
        {
            PexAssert.IsNotNull(intervaleStudent);
            PexAssert.IsNotNull(intervaleProfesor);

            Problema target =null;
            try
            {
                target = new Problema(k, n, m, intervaleStudent, intervaleProfesor);
            }
            catch(InvalidInputDataException e)
            {
                return target;
            }
            return target;
            // TODO: add assertions to method ProblemaTest.ConstructorTest(Int32, Int32, Int32, List`1<Interval>, List`1<Interval>)
        }
        [PexMethod]
        public Problema ConstructorTest(
           int k,
           List<Interval> intervaleStudent,
           List<Interval> intervaleProfesor
       )
        {
            return ConstructorTest(k, intervaleStudent.Count, intervaleProfesor.Count, intervaleStudent, intervaleProfesor);
        }
        [PexMethod(MaxStack = 200)]
        public Interval Solve([PexAssumeUnderTest] Problema target)
        {
            Interval result = target.Solve();
            return result;
            // TODO: add assertions to method ProblemaTest.Solve(Problema)
        }
    }
}