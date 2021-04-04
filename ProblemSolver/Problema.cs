using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Solver.exceptions;

namespace Solver
{
    public class Problema : CONSTANTS
    {
        private const string PATH = @"C:\Users\andrei.stanimir\source\repos\TestingProject\ProblemSolver\input_files\";
        private readonly int necessaryIntervalLength;

        private readonly int n;
        private readonly int m;
        
        private List<Interval> intervaleStudent;
        //{
        //    get
        //    {
        //        return intervaleStudent;
        //    }
        //    set
        //    {
        //        //if (value.Count != n)
        //        //{
        //        //    throw new ArgumentOutOfRangeException();
        //        //}
        //        intervaleStudent = value;
        //    }
        //}

        private List<Interval> intervaleProfesor;
        //{
        //    get
        //    {
        //        return intervaleProfesor;
        //    }
        //    //set
        //    //{
        //    //    //if (value.Count != m)
        //    //    //{
        //    //    //    throw new ArgumentOutOfRangeException();
        //    //    //}
        //    //    intervaleProfesor = value;
        //    //}
        //}
        public static bool Between(int num, int lower, int upper)
        {
            return lower <= num && num <= upper;
                        }
        public bool AreValuesInsideBounds()
        {
            AssertNumberBetween(necessaryIntervalLength, "k", 1, MAX_INTERVAL_VALUE);
            AssertNumberBetween(n, "n", 1, MAX_N);
            AssertNumberBetween(m, "m", 1, MAX_N);

            AssertListNumbersBetween(intervaleStudent);
            AssertListNumbersBetween(intervaleProfesor);
            return true;
        }
        public Problema(int k, int n, int m, List<Interval> intervaleStudent, List<Interval> intervaleProfesor)
        {
            this.necessaryIntervalLength = k;
            this.n = n;
            this.m = m;
            this.intervaleStudent = intervaleStudent;
            this.intervaleProfesor = intervaleProfesor;
            //if (n != intervaleStudent.Count)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}
            //if (m != intervaleProfesor.Count)
            //    throw new ArgumentOutOfRangeException();

            AssertNumberBetween(necessaryIntervalLength, "k", 1, MAX_INTERVAL_VALUE);
            AssertNumberBetween(n, "n", 1, MAX_N);
            AssertNumberBetween(m, "m", 1, MAX_N);

            AssertListNumbersBetween(intervaleStudent);
            AssertListNumbersBetween(intervaleProfesor);
        }

        public Problema()
        {
        }

        public Problema(string path)
        {
            path = PATH + path;
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            StreamReader reader = new StreamReader(path);
            try
            {
                if (reader.EndOfStream)
                {
                    throw new Exception("File is empty");
                }
                necessaryIntervalLength = int.Parse(reader.ReadLine());
                AssertNumberBetween(necessaryIntervalLength, "k", 1, MAX_INTERVAL_VALUE);

                n = int.Parse(reader.ReadLine());
                AssertNumberBetween(n, "n", 1, MAX_N);

                intervaleStudent = ReadInterval(reader, n);

                m = int.Parse(reader.ReadLine());
                AssertNumberBetween(m, "m", 1, MAX_N);

                intervaleProfesor = ReadInterval(reader, m);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        private List<Interval> ReadInterval(StreamReader reader, int n)
        {
            var intervals = new List<Interval>(n);

            for (int i = 0; i < n; i++)
            {
                string[] bounds = reader.ReadLine()?.Split(' ');
                if (bounds is null || bounds.Length != 2)
                {
                    throw new Exception();
                }
                if (int.TryParse(bounds[0], out int low) && int.TryParse(bounds[1], out int upper))
                {
                    AssertNumberBetween(low, "low", 0, MAX_INTERVAL_VALUE);
                    AssertNumberBetween(upper, "upper", 0, MAX_INTERVAL_VALUE);

                    if (low >= upper)
                        throw new IntervalInvalidException("Intervals must be distinct and valid");

                    Interval interval = new Interval(low, upper);
                    intervals.Add(interval);
                }
                else
                {
                    throw new IntervalInvalidException($"at postition {i}");
                }
            }
            return intervals;
        }

        private void AssertNumberBetween(int n, string name, int low, int upper)
        {
            if (n < low)
                throw new MustBeBiggerThanException(name, low);

            if (n > upper)
                throw new MustBeLowerThanException(name, upper);
        }

        private void AssertListNumbersBetween(List<Interval> intervals)
        {
            foreach (var i in intervals)
            {
                AssertNumberBetween(i.Start, "low", 0, MAX_INTERVAL_VALUE);
                AssertNumberBetween(i.Final, "upper", 0, MAX_INTERVAL_VALUE);
                if (i.Start >= i.Final)
                    throw new IntervalInvalidException("Intervals must be distinct and valid");
            }
        }

        public void PrintIntervale()
        {
            intervaleStudent.ToList().ForEach(i => Console.WriteLine($"{i.Start}, {i.Final}"));
            Console.WriteLine();
            intervaleProfesor.ToList().ForEach(i => Console.WriteLine($"{i.Start}, {i.Final}"));
        }

        public Interval? Solve()
        {
            intervaleStudent.Sort(new IntervalComparer());
            intervaleProfesor.Sort(new IntervalComparer());

            int iStudent = 0;
            int iProfesor = 0;
            while (iStudent < n && iProfesor < m)
            {
                while (intervaleStudent[iStudent].GetDuration() < necessaryIntervalLength)
                    iStudent++;
                while (intervaleProfesor[iProfesor].GetDuration() < necessaryIntervalLength)
                    iProfesor++;
                Interval student = intervaleStudent[iStudent];
                Interval profesor = intervaleProfesor[iProfesor];
                var x = Math.Max(intervaleStudent[iStudent].Start, intervaleProfesor[iProfesor].Start);
                var y = Math.Min(intervaleStudent[iStudent].Final, intervaleProfesor[iProfesor].Final);

                if (y - x >= necessaryIntervalLength)
                {
                    return new Interval(x, x + necessaryIntervalLength);
                }
                if (student.Final < profesor.Final)
                    iStudent += 1;
                else if (student.Final > profesor.Final)
                    iProfesor += 1;
                else
                {
                    iStudent += 1;
                    iProfesor += 1;
                }
            }
            return null;
        }
    }
}