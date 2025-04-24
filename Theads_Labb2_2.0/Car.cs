namespace Theads_Labb2_2._0
{
    public class Car
    {
        public string Name { get; set; }
        public double Speed { get; private set; } = 120.0d;
        public double MinLength { get; set; } = 0.0d;
        public double MaxLength { get; private set; } = 5.0 * 1000.0d;
        public bool Status { get; set; }

        //for the one who wins?
        public bool Finish { get; set; } = false;

        public Car(string name)
        {
            Name = name;
        }
    }
}
