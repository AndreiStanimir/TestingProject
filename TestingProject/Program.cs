using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestingProject.exceptions;

namespace TestingProject
{
    internal class Program
    {
        private const string PATH = @"C:\Users\andrei.stanimir\source\repos\TestingProject\TestingProject\input_files\";

        public class Problema
        {
            private const int MAX_INTERVAL_VALUE = 1_000_000_000 - 1;
            private const int MAX_N = 10_000;
            private int necessaryIntervalLength;
            private int n;
            private int m;
            private List<Interval> intervaleStudent;
            private List<Interval> intervaleProfesor;

            public Problema(int k, int n, int m, List<Interval> intervaleStudent, List<Interval> intervaleProfesor)
            {
                this.necessaryIntervalLength = k;
                this.n = n;
                this.m = m;
                this.intervaleStudent = intervaleStudent;
                this.intervaleProfesor = intervaleProfesor;
            }

            public Problema()
            {
            }

            public void ReadFile(string path)
            {
                path = PATH + path;
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException();
                }
                using (StreamReader reader = new StreamReader(path))
                {
                    try
                    {
                        if (reader.EndOfStream)
                        {
                            throw new Exception("File is empty");
                        }
                        necessaryIntervalLength = int.Parse(reader.ReadLine());
                        CheckNumberBetween(necessaryIntervalLength, "k", 1, MAX_INTERVAL_VALUE);

                        n = int.Parse(reader.ReadLine());
                        CheckNumberBetween(n, "n", 1, MAX_N);

                        ReadInterval(reader, n, out intervaleStudent);

                        m = int.Parse(reader.ReadLine());
                        CheckNumberBetween(m, "m", 1, MAX_N);

                        ReadInterval(reader, m, out intervaleProfesor);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw e;
                    }
                }
            }

            private void ReadInterval(StreamReader reader, int n, out List<Interval> intervals)
            {
                intervals = new List<Interval>(n);

                for (int i = 0; i < n; i++)
                {
                    string[] bounds = reader.ReadLine()?.Split(' ');
                    if (bounds is null || bounds.Length != 2)
                    {
                        throw new Exception();
                    }
                    if (int.TryParse(bounds[0], out int low) && int.TryParse(bounds[1], out int upper))
                    {
                        CheckNumberBetween(low, "low", 0, MAX_INTERVAL_VALUE);
                        CheckNumberBetween(upper, "upper", 0, MAX_INTERVAL_VALUE);

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
            }

            private void CheckNumberBetween(int n, string name, int low, int upper)
            {
                if (n < low)
                    throw new MustBeBiggerThanException(name, low);

                if (n > upper)
                    throw new MustBeLowerThanException(name, upper);
            }

            public void PrintIntervale()
            {
                intervaleStudent.ToList().ForEach(i => Console.WriteLine($"{i.Start}, {i.Final}"));
                Console.WriteLine();
                intervaleProfesor.ToList().ForEach(i => Console.WriteLine($"{i.Start}, {i.Final}"));
            }

            public class Interval
            {
                public int Start;
                public int Final;

                public Interval(int start, int final)
                {
                    Start = start;
                    Final = final;
                }

                public int GetDuration()
                {
                    return Final - Start;
                }

                public override string ToString()
                {
                    return Start + ", " + Final;
                }
            }

            public class IntervalComparer : Comparer<Interval>
            {
                public override int Compare(Interval x, Interval y)
                {
                    if (x.Start < y.Start)
                        return -1;
                    if (x.Start > y.Start)
                        return 1;
                    if (x.Final < y.Final)
                        return -1;
                    if (x.Final > y.Final)
                        return 1;
                    return 0;
                }
            }

            public Interval? Solve()
            {
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

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var problema = new Problema();
            problema.ReadFile("test_baza.in");
            Console.WriteLine(problema.Solve());
            problema.PrintIntervale();
        }
    }
}