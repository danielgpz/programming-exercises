using Movement;

namespace Animals
{
    public class Butterfly : IFlyer
    {
        public double Fly(double meters)
        {
            double time = meters / 5.36448;
            Console.WriteLine($"Im a butterfly flying {meters} meters in {time} seconds");
            return time;
        }
    }
}
