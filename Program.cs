namespace Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Polymorphism is used by instantiating three Geometry objects, each one
             * in a different shape.*/
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();
            Geometry circle = new Circle();

            /* Now creating an array of Geometry objects - all of them in different shapes.*/
            Geometry[] geometryArray = new Geometry[] { rectangle, square, circle };

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
