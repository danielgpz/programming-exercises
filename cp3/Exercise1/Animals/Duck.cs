using Movement;

namespace Animals
{
    public class Duck : IFlyer, ISwimmer, ITerrestrial
    {
        public double Run(double meters)
        {
            double time = meters / 3.66573;
            Console.WriteLine($"Im a duck running {meters} meters in {time} seconds");
            return time;
        }

        public double Walk(double meters)
        {
            double time = 11.0 * meters / 3.66573;
            Console.WriteLine($"Im a duck walking {meters} meters in {time} seconds");
            return time;
        }

        public double Swim(double meters)
        {
            double time = meters / 2.68224;
            Console.WriteLine($"Im a duck swimming {meters} meters in {time} seconds");
            return time;
        }

        public double Fly(double meters)
        {
            double time = meters / 44.704;
            Console.WriteLine($"Im a duck flying {meters} meters in {time} seconds");
            return time;
        }
    }
}
