using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestingProject
{
    internal class Program
    {
        private const string PATH = @"C:\Users\andrei.stanimir\source\repos\TestingProject\TestingProject\input_files\";

        public class Problema
        {
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
                    if (reader.EndOfStream)
                    {
                    }
                    necessaryIntervalLength = int.Parse(reader.ReadLine());

                    n = int.Parse(reader.ReadLine());
                    intervaleStudent = new List<Interval>(n);

                    for (int i = 0; i < n; i++)
                    {
                        string[] bounds = reader.ReadLine().Split(' ');
                        Interval interval = new Interval(int.Parse(bounds[0]), int.Parse(bounds[1]));
                        intervaleStudent.Add(interval);
                    }

                    m = int.Parse(reader.ReadLine());
                    intervaleProfesor = new List<Interval>(m);
                    for (int i = 0; i < m; i++)
                    {
                        string[] bounds = reader.ReadLine().Split(' ');
                        Interval interval = new Interval(int.Parse(bounds[0]), int.Parse(bounds[1]));
                        intervaleProfesor.Add(interval);
                    }
                    intervaleStudent.OrderBy(i => i.Start).ThenBy(i => i.Final);
                    intervaleProfesor.OrderBy(i => i.Start).ThenBy(i => i.Final);
                }
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