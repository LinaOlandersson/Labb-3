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
            Geometry triangle1 = new Triangle();
            Geometry triangle2 = new Triangle(2.89);

            /* Now creating an array of Geometry objects - regardless of their different shapes.*/
            List<Geometry> geometryList = new List<Geometry> { rectangle1, rectangle2, square1,
                square2, circle1, circle2, triangle1, triangle2 };

            /* Using polymorphism by looping through the array of Geometry objects
             * but using the properties and performing the actions of the different 
             * sub classes.*/
            Console.WriteLine("The areas of different shapes:");
            foreach (var shape in geometryList)
            {
                Console.WriteLine($"Area of {shape.Shape}: {Math.Round(shape.Area(), 2)}");
            }
            Console.WriteLine("-----------------------------------------");

            // Repeating the actions above with circumfence.
            Console.WriteLine("The circumfences of different shapes:");
            foreach (var shape in geometryList)
            {
                Console.WriteLine($"Circumfence of {shape.Shape}: {Math.Round(shape.Circumfence(), 2)}");
            }
            Console.WriteLine("-----------------------------------------");

            // Sorting the list based on area.
            geometryList.Sort((x, y) => x.Area().CompareTo(y.Area()));

            // Printing the sorted list.
            Console.WriteLine("The shapes in order of increasing area: ");
            foreach (var shape in geometryList)
            {
                Console.WriteLine($"Area of {shape.Shape}: {Math.Round(shape.Area(), 2)}");
            }
        }
    }
}
