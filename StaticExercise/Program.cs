namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\n----------Fahtenheit To Celsius----------");
            Console.WriteLine(TempConverter.FahtenheitToCelsius(32));

            Console.WriteLine("\n----------Celsius To Fahrenheit----------");
            Console.WriteLine($"{TempConverter.CelsiusToFahrenheit(0)}");
        }
    }
}
