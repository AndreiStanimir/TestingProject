namespace Solver {

    public class Interval {
        public int Start;
        public int Final;

        public Interval(int start, int final) {
            Start = start;
            Final = final;
        }

        public override bool Equals(object obj) {
            return obj is Interval interval &&
                   Start == interval.Start &&
                   Final == interval.Final;
        }

        public int GetDuration() {
            return Final - Start;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string ToString() {
            return Start + ", " + Final;
        }
    }
}