using Movement;

namespace Animals
{
    public class Cat : ITerrestrial
    {
        public double Run(double meters)
        {
            double time = meters / 26.9444;
            Console.WriteLine($"Im a cat running {meters} meters in {time} seconds");
            return time;
        }

        public double Walk(double meters)
        {
            double time = 10.0 * meters / 26.9444;
            Console.WriteLine($"Im a cat walking {meters} meters in {time} seconds");
            return time;
        }
    }
}
