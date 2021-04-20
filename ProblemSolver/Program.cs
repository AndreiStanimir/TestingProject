using System;

namespace Solver {

    public partial class Program {

        private static void Main(string[] args) {
            var problema = new Problema("test_baza.in");
            Console.WriteLine($"Solutia {problema.Solve()}\n");
            problema.PrintIntervale();
        }
    }
}