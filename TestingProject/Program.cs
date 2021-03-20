using System;
using System.Collections.Generic;
using System.IO;

namespace TestingProject
{
    internal class Program
    {
        
        public class Interval
        {
            public int Start;
            public int Final;

            public Interval(int start, int final)
            {
                Start = start;
                Final = final;
            }
        }
        public class IntervalComparer : Comparer<Interval>
        {
            public override int Compare(Interval x, Interval y)
            {
                return x.Start<y.Start;
            }
        }


        private static void Solve(string path)
        {
            ReadFile(path);

        }

        private static void ReadFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            var k = int.Parse(reader.ReadLine());
            var n = int.Parse(reader.ReadLine());

            List<Interval> intervaleStudent = new List<Interval>(n);

            for (int i = 0; i < n; i++)
            {
                string[] bounds = reader.ReadLine().Split(' ');
                Interval interval = new Interval(int.Parse(bounds[0]), int.Parse(bounds[1]));
                intervaleStudent[i] = interval;
            }

            var m = int.Parse(reader.ReadLine());
            List<Interval> intervaleProfesor = new List<Interval>(n);

            for (int i = 0; i < m; i++)
            {
                string[] bounds = reader.ReadLine().Split(' ');
                Interval interval = new Interval(int.Parse(bounds[0]), int.Parse(bounds[1]));
                intervaleProfesor[i] = interval;
            }

            intervaleProfesor.Sort()
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}