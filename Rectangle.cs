namespace Labb_3
{
    internal class Rectangle : Geometry
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public override string Shape => "Rectangle";

        public Rectangle()
        {
            SideA = 6.15;
            SideB = 2.23;
        }
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double Area()
        {
            return SideA * SideB;
        }
        public override double Circumfence()
        {
            return (SideA * 2) + (SideB * 2);
        }
    }
}
