namespace Labb_3
{
    public abstract class Geometry
    {
        /* Each sub class inheriting from this abstract Geometry class must 
         * define a property of the shape and implement a method to calculate 
         * the area and circumfence. Polymorphism is shown by that the shapes 
         * and methods are defined in different ways in each sub class. */
        public abstract string Shape { get; }
        public abstract double Area();
        public abstract double Circumfence();
    }
}
