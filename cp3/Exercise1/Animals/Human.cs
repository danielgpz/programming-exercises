using Movement;

namespace Animals
{
    public abstract class Human {
        public abstract void Talk(string speech);
    }
    public class Human_A: Human, IRunner
    {
        public override void Talk(string speech) {
            Console.WriteLine($"A: {speech}");
        }

        // Explicit interface member implementation:
        double IHuman.Walk(double meters) {
            Console.WriteLine("Human A walking as IHuman");
            return 11.0 * meters / 12.217603;
        }

        // Explicit interface member implementation:
        double ITerrestrial.Walk(double meters)
        {
            Console.WriteLine("Human A walking as ITerrestrial");
            return 10.0 * meters / 12.217603;
        }

        // Implicit interface member implementation:
        public double Run(double meters) {
            Console.WriteLine("Human A running");
            return meters / 12.217603;
        }
    }

    public class Human_B : Human, IRunner
    {
        public override void Talk(string speech)
        {
            Console.WriteLine($"B: {speech}");
        }

        // Implicit interface member implementation:
        public double Walk(double meters)
        {
            Console.WriteLine("Human B walking");
            return 10.0 * meters / 12.217603;
        }

        // Implicit interface member implementation:
        public double Run(double meters)
        {
            Console.WriteLine("Human B running");
            return meters / 12.217603;
        }
    }
}