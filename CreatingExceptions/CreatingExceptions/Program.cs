namespace CreatingExceptions
{
    internal class Program
    {
        /*
         * Purpose: Create custom exceptions for a circle class and test/debug them
         * Author: Logan
         * When: March 2025
         */
        static void MakeCircle(double radius)
        {
            try
            {
                Circle circle = new Circle(radius);
                Console.WriteLine(circle.ToString());
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        static void Main(string[] args)
        {
            MakeCircle(25);
            MakeCircle(-20);
            MakeCircle(20);
            MakeCircle(10);
            MakeCircle(0);
        }
        
    }
}
