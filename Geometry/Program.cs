namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rectangleArea = GeometryHelper.CalculateRectangleArea(4, 6);
            Console.WriteLine("Dörtgenin alanı: " + rectangleArea);

            double triangleArea = GeometryHelper.CalculateTriangleArea(3, 5);
            Console.WriteLine("Üçgenin alanı: " + triangleArea);

            double circleArea = GeometryHelper.CalculateCircleArea(2);
            Console.WriteLine("Dairenin alanı: " + circleArea);

            Console.ReadLine();

        }
    }
}