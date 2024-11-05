namespace Labb_3
{
    internal class Square : Geometry
    {
        public double Side { get; set; }
        public override string Shape => "Square";

        public Square()
        {
            Side = 5.64;
        }
        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
