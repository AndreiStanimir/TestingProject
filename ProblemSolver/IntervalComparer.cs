using System.Collections.Generic;

namespace Solver {

    public class IntervalComparer : Comparer<Interval> {

        public override int Compare(Interval x, Interval y) {
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
}