namespace csharp_vacio
{
    public class Convertir : IConvertir
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 0.5556;
        }
    }
}