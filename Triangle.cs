namespace Labb_3
{
    internal class Triangle : Geometry
    {
        public double Side;
        public override string Shape => "Triangle";

        public Triangle()
        {
            Side = 12.23;
        }
        public Triangle(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return (Math.Sqrt(3)/4) * Side * Side;
        }
        public override double Circumfence()
        {
            return Side * 3;
        }
    }
}
