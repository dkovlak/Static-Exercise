using System;
namespace StaticExercise
{
	public class TempConverter
	{
		public TempConverter()
		{
		}

		public static double FahtenheitToCelsius(double num)
			{
			double result = (num - 32) * 5.0 / 9.0;
			Console.WriteLine($"{num}°F = {result}°C");
			return result;
			}

		public static double CelsiusToFahrenheit(double num)
		{
			double result = (num * 9.0 / 5.0) + 32;
            Console.WriteLine($"{num}°C = {result}°F");
            return result;
		}
	}
}

