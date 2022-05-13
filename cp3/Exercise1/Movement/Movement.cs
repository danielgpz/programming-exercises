namespace Movement
{
    public interface ITerrestrial {
        double Run(double meters);

        double Walk(double meters);
    }

    public interface IFlyer {
        double Fly(double meters);
    }

    public interface ISwimmer {
        double Swim(double meters);
    }

    public interface IHuman {
        void Talk(string speech);

        double Walk(double meters);
    }

    public interface IRunner : ITerrestrial, IHuman { }
}