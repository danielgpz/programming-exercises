using Movement;

namespace Animals
{
    public class Shark : ISwimmer
    {
        public double Swim(double meters)
        {
            double time = meters / 18.0;
            Console.WriteLine($"Im a shark swimming {meters} meters in {time} seconds");
            return time;
        }
    }
}
