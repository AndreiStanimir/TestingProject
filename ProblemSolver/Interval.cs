namespace Solver
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

        public int GetDuration()
        {
            return Final - Start;
        }

        public override string ToString()
        {
            return Start + ", " + Final;
        }
    }
}