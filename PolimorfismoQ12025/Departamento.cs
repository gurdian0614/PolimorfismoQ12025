
namespace PolimorfismoQ12025
{
    public class Departamento : Inmueble
    {
        public void Vender(string Ubicacion, double AreaTerreno, double Precio)
        {
            Console.WriteLine($"Departamento con ubicación en {Ubicacion}, con un área de {AreaTerreno} mts2, ha sido vendido por el precio de L{Precio}");
        }
    }
}
