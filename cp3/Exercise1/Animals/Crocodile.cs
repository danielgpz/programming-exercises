using Movement;

namespace Animals
{
    public class Crocodile : ITerrestrial, ISwimmer
    {
        public double Run(double meters)
        {
            double time = meters / 8.88889;
            Console.WriteLine($"Im a crocodile running {meters} meters in {time} seconds");
            return time;
        }

        public double Walk(double meters)
        {
            double time = 12.0 * meters / 8.88889;
            Console.WriteLine($"Im a crocodile walking {meters} meters in {time} seconds");
            return time;
        }

        public double Swim(double meters)
        {
            double time = meters / 5.543296;
            Console.WriteLine($"Im a crocodile swimming {meters} meters in {time} seconds");
            return time;
        }
    }
}
