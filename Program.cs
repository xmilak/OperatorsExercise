namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)

        {
            var a = 17;
            var b = 4;
            var sum = a + b;
            Console.WriteLine($"a + b = {sum}");

            var diff = a - b;

            Console.WriteLine($"a - b = {diff}");

            Console.WriteLine($"a x b = {a * b}");

            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            // Exercise 2

            Console.WriteLine("What is radius of your circle?");

            var radius = double.Parse( Console.ReadLine() );

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
            

        }
    }
}