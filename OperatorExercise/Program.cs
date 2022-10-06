namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
        
            Console.WriteLine("What is the radius of your circle");

            var radius = double.Parse(Console.ReadLine());
            var pi = Math.PI;

            var areaOfCircle = pi * (radius * radius);

            Console.WriteLine($"The area of a circle with the radius of {radius} is {areaOfCircle}");      
        }
    }
}
