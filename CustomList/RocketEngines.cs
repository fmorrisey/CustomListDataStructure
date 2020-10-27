namespace CustomListProj
{
    public abstract class RocketEngines
    {
        protected double _thrust;
        protected double _mass;
        protected string _cycle;

        public string Name;
        public double Thrust { get => _thrust; }
        public double Mass { get => _mass; }
        public string Cycle { get => _cycle; }




    }
}
