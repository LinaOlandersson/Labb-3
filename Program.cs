namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Polymorphism is used by instantiating Geometry objects with different shapes.*/
            Geometry rectangle1 = new Rectangle();
            Geometry rectangle2 = new Rectangle(23.43, 12.12);
            Geometry square1 = new Square();
            Geometry square2 = new Square(3.14);
            Geometry circle1 = new Circle();
            Geometry circle2 = new Circle(78.5);

            /* Now creating an array of Geometry objects - regardless of their different shapes.*/
            Geometry[] geometryArray = new Geometry[] { rectangle1, rectangle2, square1,
                square2, circle1, circle2 };

            /* Using polymorphism by looping through the array of Geometry objects
             * but using the properties and performing the actions of the different 
             * sub classes.*/
            foreach (var shape in geometryArray)
            {
                Console.WriteLine($"Area of {shape.Shape}: {Math.Round(shape.Area(), 2)}");
            }
        }
    }
}
