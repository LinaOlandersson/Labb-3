namespace Labb_3
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public override string Shape => "Circle";

        public Circle()
        {
            Radius = 2.53;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
