using Solver;
// <copyright file="ProblemaFactory.cs" company="Avira Operations GmbH &amp; Co. KG;">Copyright © Avira Operations GmbH &amp; Co. KG; 2021</copyright>

using System;
using Microsoft.Pex.Framework;
using System.Collections.Generic;

namespace Solver
{
    /// <summary>A factory for Solver.Problema instances</summary>
    public static partial class ProblemaFactory
    {
        /// <summary>A factory for Solver.Problema instances</summary>
        [PexFactoryMethod(typeof(Problema))]
        public static Problema Create(string path_s)
        {
            Problema problema = new Problema(path_s);
            return problema;

            // TODO: Edit factory method of Problema
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.

        }
        [PexFactoryMethod(typeof(Problema))]
        public static Problema Create(
           int k,
           int n,
           int m,
           List<Interval> intervaleStudent,
           List<Interval> intervaleProfesor
       )
        {
            Problema problema = new Problema(k, n, m, intervaleStudent, intervaleProfesor);
            return problema;
        }
    }
}
