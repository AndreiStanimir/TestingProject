using System;
using System.Linq;

namespace Solver
{
    public partial class Program
    {
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