using Movement;
using Animals;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTerrestrials");
            ITerrestrial[] terrestrials = new ITerrestrial[] { new Cat(), new Crocodile(), new Duck() };
            foreach (ITerrestrial terrestrial in terrestrials) {
                double walk_time = terrestrial.Walk(100.0);
                double run_time = terrestrial.Run(100.0);
            }

            Console.WriteLine("\nSwimmers");
            ISwimmer[] swimmers = new ISwimmer[] { new Shark(), new Crocodile(), new Duck() };
            foreach (ISwimmer swimmer in swimmers)
            {
                double swim_time = swimmer.Swim(100.0);
            }

            Console.WriteLine("\nFlyers");
            IFlyer[] flyers = new IFlyer[] { new Butterfly(), new Duck() };
            foreach (IFlyer flyer in flyers)
            {
                double swim_time = flyer.Fly(100.0);
            }

            Console.WriteLine("\nHumans");
            Human_A a = new Human_A();
            Human_B b = new Human_B();

            IRunner r_a = a;
            IRunner r_b = b;

            // t_a.Walk(100.0);
            ((IHuman)r_a).Walk(100.0);
            ((ITerrestrial)r_a).Walk(100.0);
            r_a.Run(100.0);

            // t_b.Walk(100.0);
            ((IHuman)r_b).Walk(100.0);
            ((ITerrestrial)r_b).Walk(100.0);
            r_b.Run(100.0);
        }
    }
}
