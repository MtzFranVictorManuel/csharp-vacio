using System.ServiceModel;

namespace csharp_vacio
{
    [ServiceContract]
    public interface IConvertir
    {
        [OperationContract]
        double CelsiusToFahrenheit(double celsius);

        [OperationContract]
        double FahrenheitToCelsius(double fahrenheit);
    }
}